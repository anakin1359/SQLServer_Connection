using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hoimi.Models;
using Hoimi.SqlServer;

namespace Hoimi
{
	public partial class InsertCommandButton : Form
	{
		public InsertCommandButton()
		{
			InitializeComponent();

			StartPosition = FormStartPosition.CenterScreen;
		}

		private void DataTableReadButton_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ProductSqlServer.GetDataTable();
		}

		private void ReaderreadButton_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ProductSqlServer.GetDataReader();
		}

		private void InsertCmdButton_Click(object sender, EventArgs e)
		{
			int productId = Convert.ToInt32(ProductIdTextBox.Text);
			string productName = ProductNameTextBox.Text;
			int price = Convert.ToInt32(PriceTextBox.Text);

			var entity = new ProductEntity(productId, productName, price);
			ProductSqlServer.Insert(entity);
		}

		private void UpdateCmdButton_Click(object sender, EventArgs e)
		{
			int productId = Convert.ToInt32(ProductIdTextBox.Text);
			string productName = ProductNameTextBox.Text;
			int price = Convert.ToInt32(PriceTextBox.Text);

			var entity = new ProductEntity(productId, productName, price);
			ProductSqlServer.Update(entity);
		}

		private void DeleteCmdButton_Click(object sender, EventArgs e)
		{
			int productId = Convert.ToInt32(ProductIdTextBox.Text);
			ProductSqlServer.Delete(productId);
		}

		private void DapperReadButton_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ProductSqlServer.GetDapper();
		}

		// DapperでのInsert処理を定義
		private void DapperInsertButton_Click(object sender, EventArgs e)
		{
			int productId = Convert.ToInt32(ProductIdTextBox.Text);
			string productName = ProductNameTextBox.Text;
			int price = Convert.ToInt32(PriceTextBox.Text);

			var entity = new ProductEntity(productId, productName, price);
			ProductSqlServer.DapperInsert(entity);
		}

		// EntityFramework でのデータ取得処理
		private void EFReadButton_Click(object sender, EventArgs e)
		{
			var source = new List<Product>();
			using (var db = new HoimiDbContext())
			{
				source.AddRange(db.Products);
			}

			dataGridView1.DataSource = source;
		}

		// EntityFramework Insert処理
		private void EFInsertButton_Click(object sender, EventArgs e)
		{
			Product p = new Product();
			p.ProductId = Convert.ToInt32(ProductIdTextBox.Text);
			p.ProductName = ProductNameTextBox.Text;
			p.Price = Convert.ToInt32(PriceTextBox.Text);

			using (var db = new HoimiDbContext())
			{
				db.Products.Add(p);
				db.SaveChanges();
			}
		}
	}
}
