using System;
using System.Windows.Forms;
using BLL.InputModels.Category;
using BLL.Services;
using BLL.Services.Contracts;
using Newtonsoft.Json;

namespace IncomeManager
{
    public partial class AddCategory : Form
    {
        private readonly AddArtikulForm parrent;

        private readonly ICategoryService categoryService;

        public AddCategory(AddArtikulForm parrent)
        {
            InitializeComponent();
            categoryService = new CategoryService();
            this.parrent = parrent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                string categoryName = textName.Text;

                if (string.IsNullOrEmpty(categoryName))
                {
                    MessageBox.Show("Please enter category name!");
                    return;
                }

                if (categoryName.Length > 100)
                {
                    MessageBox.Show("Category name should be between 0 and 100 characters");
                    return;
                }

                AddCategoryInputModel inputModel = new AddCategoryInputModel
                {
                    Name = categoryName,
                };

                string inputModelJson = JsonConvert.SerializeObject(inputModel);

                categoryService.AddCategory(inputModelJson);
                MessageBox.Show("Successfully added new category");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async void AddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            await parrent.LoadCategoriesAsync();
        }
    }
}
