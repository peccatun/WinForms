using SalesSystemJupiterSoft.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystemJupiterSoft
{
    public partial class EnterArticleForm : Form
    {
        private readonly IArticleService articleService;

        public EnterArticleForm()
        {
            InitializeComponent();
            articleService = (IArticleService)Program.ServiceProvider.GetService(typeof(IArticleService));
        }

        private void BackToMenuFormBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateArticleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ArticleNameTextBox.Text))
            {
                MessageBox.Show("You have not entered article name",
                    "Article name field is empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (ArticleNameTextBox.TextLength > 50)
            {
                MessageBox.Show("Article name must be less than 50 characters long"
                    ,"Article name is too long"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);
            }

            if (decimal.TryParse(ArticlePriceTextBox.Text, out decimal articlePrice))
            {
                if (articlePrice <= 0)
                {
                    MessageBox.Show("Article price can't be a negative number or zero",
                        "Invalid article price",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Article price must be a number" ,
                    "You have not entered a number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

            if (ArticleCodeTextBox.TextLength > 10)
            {
                MessageBox.Show("Article Code can't be more than 10 characters",
                    "Invalid article code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (string.IsNullOrEmpty(ArticleCodeTextBox.Text))
            {
                MessageBox.Show("Enter article code",
                    "Invalid article code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            string articleName = ArticleNameTextBox.Text;
            string articleCode = ArticleCodeTextBox.Text;

            articleService.CreateArticle(articleName,articlePrice,articleCode);

            MessageBox.Show($"You have successfully created article \"{articleName}\" with code \"{articleCode}\" and price: {articlePrice}",
                "Creation succeeded",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ResetTextBoxes();
        }

        private void ResetTextBoxes()
        {
            ArticleNameTextBox.Text = string.Empty;
            ArticlePriceTextBox.Text = string.Empty;
            ArticleCodeTextBox.Text = string.Empty;
        }
    }
}
