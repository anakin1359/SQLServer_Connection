namespace Hoimi
{
	partial class InsertCommandButton
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.DataTableReadButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ReaderreadButton = new System.Windows.Forms.Button();
			this.ProductIdTextBox = new System.Windows.Forms.TextBox();
			this.PriceTextBox = new System.Windows.Forms.TextBox();
			this.ProductNameTextBox = new System.Windows.Forms.TextBox();
			this.InsertCmdButton = new System.Windows.Forms.Button();
			this.UpdateCmdButton = new System.Windows.Forms.Button();
			this.DeleteCmdButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// DataTableReadButton
			// 
			this.DataTableReadButton.Location = new System.Drawing.Point(24, 21);
			this.DataTableReadButton.Name = "DataTableReadButton";
			this.DataTableReadButton.Size = new System.Drawing.Size(172, 37);
			this.DataTableReadButton.TabIndex = 0;
			this.DataTableReadButton.Text = "DataTable read";
			this.DataTableReadButton.UseVisualStyleBackColor = true;
			this.DataTableReadButton.Click += new System.EventHandler(this.DataTableReadButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(285, 71);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(553, 472);
			this.dataGridView1.TabIndex = 1;
			// 
			// ReaderreadButton
			// 
			this.ReaderreadButton.Location = new System.Drawing.Point(24, 85);
			this.ReaderreadButton.Name = "ReaderreadButton";
			this.ReaderreadButton.Size = new System.Drawing.Size(172, 37);
			this.ReaderreadButton.TabIndex = 2;
			this.ReaderreadButton.Text = "Reader read";
			this.ReaderreadButton.UseVisualStyleBackColor = true;
			this.ReaderreadButton.Click += new System.EventHandler(this.ReaderreadButton_Click);
			// 
			// ProductIdTextBox
			// 
			this.ProductIdTextBox.Location = new System.Drawing.Point(285, 27);
			this.ProductIdTextBox.Name = "ProductIdTextBox";
			this.ProductIdTextBox.Size = new System.Drawing.Size(161, 25);
			this.ProductIdTextBox.TabIndex = 3;
			// 
			// PriceTextBox
			// 
			this.PriceTextBox.Location = new System.Drawing.Point(677, 27);
			this.PriceTextBox.Name = "PriceTextBox";
			this.PriceTextBox.Size = new System.Drawing.Size(161, 25);
			this.PriceTextBox.TabIndex = 4;
			// 
			// ProductNameTextBox
			// 
			this.ProductNameTextBox.Location = new System.Drawing.Point(482, 27);
			this.ProductNameTextBox.Name = "ProductNameTextBox";
			this.ProductNameTextBox.Size = new System.Drawing.Size(161, 25);
			this.ProductNameTextBox.TabIndex = 5;
			// 
			// InsertCmdButton
			// 
			this.InsertCmdButton.Location = new System.Drawing.Point(24, 152);
			this.InsertCmdButton.Name = "InsertCmdButton";
			this.InsertCmdButton.Size = new System.Drawing.Size(172, 37);
			this.InsertCmdButton.TabIndex = 6;
			this.InsertCmdButton.Text = "Insert cmd";
			this.InsertCmdButton.UseVisualStyleBackColor = true;
			this.InsertCmdButton.Click += new System.EventHandler(this.InsertCmdButton_Click);
			// 
			// UpdateCmdButton
			// 
			this.UpdateCmdButton.Location = new System.Drawing.Point(24, 217);
			this.UpdateCmdButton.Name = "UpdateCmdButton";
			this.UpdateCmdButton.Size = new System.Drawing.Size(172, 37);
			this.UpdateCmdButton.TabIndex = 7;
			this.UpdateCmdButton.Text = "Update cmd";
			this.UpdateCmdButton.UseVisualStyleBackColor = true;
			this.UpdateCmdButton.Click += new System.EventHandler(this.UpdateCmdButton_Click);
			// 
			// DeleteCmdButton
			// 
			this.DeleteCmdButton.Location = new System.Drawing.Point(24, 284);
			this.DeleteCmdButton.Name = "DeleteCmdButton";
			this.DeleteCmdButton.Size = new System.Drawing.Size(172, 37);
			this.DeleteCmdButton.TabIndex = 8;
			this.DeleteCmdButton.Text = "Delete cmd";
			this.DeleteCmdButton.UseVisualStyleBackColor = true;
			this.DeleteCmdButton.Click += new System.EventHandler(this.DeleteCmdButton_Click);
			// 
			// InsertCommandButton
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 555);
			this.Controls.Add(this.DeleteCmdButton);
			this.Controls.Add(this.UpdateCmdButton);
			this.Controls.Add(this.InsertCmdButton);
			this.Controls.Add(this.ProductNameTextBox);
			this.Controls.Add(this.PriceTextBox);
			this.Controls.Add(this.ProductIdTextBox);
			this.Controls.Add(this.ReaderreadButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.DataTableReadButton);
			this.Name = "InsertCommandButton";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button DataTableReadButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button ReaderreadButton;
		private System.Windows.Forms.TextBox ProductIdTextBox;
		private System.Windows.Forms.TextBox PriceTextBox;
		private System.Windows.Forms.TextBox ProductNameTextBox;
		private System.Windows.Forms.Button InsertCmdButton;
		private System.Windows.Forms.Button UpdateCmdButton;
		private System.Windows.Forms.Button DeleteCmdButton;
	}
}

