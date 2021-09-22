using BLL.Services;
using BLL.Services.Contracts;
using BLL.ViewModels.ApplicationUser;
using BLL.ViewModels.Item;
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
    public partial class AddSellForm : Form
    {
        private readonly IApplicationUserService applicationUserService;
        private readonly IItemService itemService;

        public AddSellForm()
        {
            InitializeComponent();

            applicationUserService = new ApplicationUserService();
            itemService = new ItemService();
        }

        private void btnAddArtikul_Click(object sender, EventArgs e)
        {
            AddArtikulForm addArtikul = new AddArtikulForm();
            addArtikul.FormClosing += new FormClosingEventHandler(AddSellForm_Load);
            addArtikul.Show();
        }

        private async void AddSellForm_Load(object sender, EventArgs e)
        {
            await LoadItemsAsync();
            await LoadUsersAsync();
        }

        private async Task LoadItemsAsync()
        {
            string itemsListJson = await itemService.GetItemListJsonAsync();

            List<ItemViewModel> itemList = JsonConvert.DeserializeObject<List<ItemViewModel>>(itemsListJson);

            comboArtikuls.DisplayMember = "Name";
            comboArtikuls.ValueMember = "ItemId";
            comboArtikuls.DataSource = new BindingSource(itemList, null);
        }

        private async Task LoadUsersAsync()
        {
            string appUserListJson = await applicationUserService.GetApplicationUserListJsonAsync();

            List<ApplicationUserViewModel> appUserList = JsonConvert.DeserializeObject<List<ApplicationUserViewModel>>(appUserListJson);

            comboUser.DisplayMember = "Username";
            comboUser.ValueMember = "UserId";
            comboUser.DataSource = new BindingSource(appUserList, null);
        }
    }
}
