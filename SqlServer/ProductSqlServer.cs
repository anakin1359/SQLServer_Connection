using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoimi.SqlServer
{
	public static class ProductSqlServer
	{
		private static string _connectionString;
		static ProductSqlServer()
		{
			var builder = new SqlConnectionStringBuilder();
			builder.DataSource = @"DESKTOP-KB1CUHS";
			builder.InitialCatalog = "Hoimi";
			builder.IntegratedSecurity = true;
			_connectionString = builder.ToString();
		}

		public static DataTable GetDataTable()
		{
			var sql = @"select * from Product";

			DataTable dt = new DataTable();
			using (var connection = new SqlConnection(_connectionString))
			using (var adapter = new SqlDataAdapter(sql, connection))
			{
				connection.Open();
				adapter.Fill(dt);
			}

			return dt;
		}

		public static List<ProductEntity> GetDataReader()
		{
			var sql = @"select * from Product";
			var result = new List<ProductEntity>();
			using (var connection = new SqlConnection(_connectionString))
			using (var command = new SqlCommand(sql, connection))
			{
				connection.Open();
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						result.Add(new ProductEntity(
							Convert.ToInt32(reader["ProductId"]),
							Convert.ToString(reader["ProductName"]),
							Convert.ToInt32(reader["Price"])));
					}
				}
			}

			return result;
		}

		public static void Insert(ProductEntity product)
		{
			string sql = @"
insert into Product
(ProductId,
ProductName,
Price)
values
(
@ProductId,
@ProductName,
@Price
)
";
			using (var connection = new SqlConnection(_connectionString))
			using (var command = new SqlCommand(sql, connection))
			{
				connection.Open();

				command.Parameters.AddWithValue("@ProductId", product.ProductId);
				command.Parameters.AddWithValue("@ProductName", product.ProductName);
				command.Parameters.AddWithValue("@Price", product.Price);

				command.ExecuteNonQuery();
			}
		}

		public static void Update(ProductEntity product)
		{
			string sql = @"
update Product
	set ProductName = @ProductName,
		Price = @Price
	where ProductId = @ProductId
";
			using (var connection = new SqlConnection(_connectionString))
			using (var command = new SqlCommand(sql, connection))
			{
				connection.Open();
				command.Parameters.AddWithValue("@ProductId", product.ProductId);
				command.Parameters.AddWithValue("@ProductName", product.ProductName);
				command.Parameters.AddWithValue("@Price", product.Price);
				command.ExecuteNonQuery();
			}
		}
	}
}
