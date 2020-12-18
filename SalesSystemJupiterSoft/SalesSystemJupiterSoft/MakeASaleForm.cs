using SalesSystemJupiterSoft.Services;
using SalesSystemJupiterSoft.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesSystemJupiterSoft
{
    public partial class MakeASaleForm : Form
    {
        private readonly ISalesService salesService;
        private readonly IArticleService articleService;

        public MakeASaleForm()
        {
            InitializeComponent();
            salesService = (ISalesService)Program.ServiceProvider.GetService(typeof(ISalesService));
            articleService = (IArticleService)Program.ServiceProvider.GetService(typeof(IArticleService));
        }

        private void BackToMenuFromSalesBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSaleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ArticleComboBox.Text))
            {
                MessageBox.Show("You havent specified an article",
                    "Invalid article",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(ArticleQuantityTextBox.Text))
            {
                MessageBox.Show("You have to enter quantity to make a sale",
                    "Invalid quantity",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (!int.TryParse(ArticleQuantityTextBox.Text,out int articleQuantity))
            {
                MessageBox.Show("Quantity must be a whole number",
                    "Invalid Quantity",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string articleName = ArticleComboBox.Text;
            int articleId = articleService.GetArticleIdByName(articleName);
            this.salesService.MakeSale(articleId,articleQuantity);
            MessageBox.Show("You have successfully made a sale",
                "Sale successfull",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateDataGridView();
        }

        private void MakeASaleForm_Load(object sender, EventArgs e)
        {
            IEnumerable<string> articles = this.articleService.GetArticles();

            foreach (var item in articles)
            {
                ArticleComboBox.Items.Add(item);
            }

            dataGridView1.DataSource = salesService.GetSalesForDGV();
            

        }

        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = salesService.GetSalesForDGV();
        }

        private void CreateDataGridViewColums()
        {
            dataGridView1.Columns.Add("ItemName", "Item Name");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("ItemPrice", "Item Price");
            dataGridView1.Columns.Add("SumPrice", "Sum Price");
            dataGridView1.Columns.Add("SoldDate", "Sold Date");
        }
    }
}
