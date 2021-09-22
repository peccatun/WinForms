using BLL.InputModels.ApplicationUser;
using BLL.Services;
using BLL.Services.Contracts;
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
    public partial class AddUserForm : Form
    {
        private readonly Form parrent;

        private readonly IApplicationUserService applicationUserService;

        public AddUserForm(Form parrent)
        {
            InitializeComponent();
            this.parrent = parrent;
            applicationUserService = new ApplicationUserService();
        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textUsername.Text;

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Invalid Username");
                    return;
                }
                if (username.Length > 100)
                {
                    MessageBox.Show("Invalid Username");
                    return;
                }

                ApplicationUserInputModel inputModel = new ApplicationUserInputModel
                {
                    UserName = username,
                };

                string inputModelJson = JsonConvert.SerializeObject(inputModel);

                await applicationUserService.InsertApplicationUserAsync(inputModelJson);

                MessageBox.Show("Successfully added new user");
                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void AddUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parrent.WindowState = FormWindowState.Normal;
        }
    }
}
