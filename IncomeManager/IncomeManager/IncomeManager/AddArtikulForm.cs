using BLL.DecimalPointConverter;
using BLL.InputModels.Item;
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
        private readonly IItemService itemService;

        public AddArtikulForm()
        {
            InitializeComponent();

            categoryService = new CategoryService();
            itemService = new ItemService();
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string itemName = textName.Text;

            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Insert item name");
                return;
            }

            if (itemName.Length > 100)
            {
                MessageBox.Show("Item name must be between 0 and 100 symbols");
                return;
            }

            if (comboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Item must have category!");
                return;
            }

            string priceString = textPrice.Text;

            if (string.IsNullOrEmpty(priceString))
            {
                MessageBox.Show("Item must have price!");
                return;
            }

            double price = -1d;

            if (!double.TryParse(DecimalPointConverter.GetStringDecimal(priceString), out double result))
            {
                MessageBox.Show("Price must be a number!");
                return;
            }

            price = result;
            long categoryId = long.Parse(comboCategory.SelectedValue.ToString());

            ItemInputModel inputModel = new ItemInputModel
            {
                CategoryId = categoryId,
                Name = itemName,
                Price = price,
            };

            string inputModelJson = JsonConvert.SerializeObject(inputModel);

            await itemService.InsertItemAsync(inputModelJson);

            MessageBox.Show("Successfully insert artikul");

            var dialogResult = MessageBox.Show("Will you insert more artikuls?", "IncomeManager",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                Close();
            }

            textName.ResetText();
            textPrice.ResetText();
        }
    }
}
