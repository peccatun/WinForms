using BLL.Services;
using BLL.Services.Contracts;
using BLL.ViewModels.Category;
using IncomeManager.ViewModels.ComboBox;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeManager
{
    public partial class AddArtikulForm : Form
    {
        private readonly ICategoryService categoryService;

        public AddArtikulForm()
        {
            InitializeComponent();

            categoryService = new CategoryService();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory(this);
            addCategory.Show();
        }

        private async void AddArtikulForm_Load(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();
        }

        public async Task LoadCategoriesAsync()
        {
            string categoryItemsJson = await categoryService.GetCategoriesAsync();

            List<CategoryViewModel> comboItems = JsonConvert.DeserializeObject<List<CategoryViewModel>>(categoryItemsJson);

            comboCategory.DisplayMember = "Name";
            comboCategory.ValueMember = "Id";

            comboCategory.DataSource = new BindingSource(comboItems, null);
        }
    }
}
