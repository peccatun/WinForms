using BLL.Services;
using BLL.Services.Contracts;
using BLL.ViewModels.Category;
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
            List<ComboBoxItemViewModel> comboItems = await categoryService.GetCategoriesAsync();

            comboCategory.DisplayMember = "Key";
            comboCategory.ValueMember = "Value";

            comboCategory.DataSource = new BindingSource(comboItems, null);
        }
    }
}
