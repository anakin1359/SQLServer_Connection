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
	}
}
