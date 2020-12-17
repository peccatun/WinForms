using SalesSystemJupiterSoft.Services;
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
            string articleName = ArticleComboBox.Text;
            int articleId = articleService.GetArticleIdByName(articleName);
            int articleQuantity = int.Parse(ArticleQuantityTextBox.Text);
        }

        private void MakeASaleForm_Load(object sender, EventArgs e)
        {
            IEnumerable<string> articles = this.articleService.GetArticles();

            foreach (var item in articles)
            {
                ArticleComboBox.Items.Add(item);
            }
        }
    }
}
