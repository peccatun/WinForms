using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.Services;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcycleMaintenance
{
    public partial class NewUserForm : Form
    {
        private readonly IUserService userService;

        public NewUserForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length > 10 || PasswordTextBox.Text.Length > 10)
            {
                MessageBox.Show(
                    "Username/Password must be less than 10 symbols",
                    GlobalConstants.MessageBoxTopInfo,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (!PasswordTextBox.Text.Equals(ConfirmPasswordTextBox.Text))
            {
                MessageBox.Show(
                    "Password and confirm password do not match",
                     GlobalConstants.MessageBoxTopInfo,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);

                return;
            }

            try
            {
                userService.CreateUser(UsernameTextBox.Text, PasswordTextBox.Text);
                MessageBox.Show("Success", GlobalConstants.MessageBoxTopInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server error", GlobalConstants.MessageBoxTopInfo,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                this.Close();
            }




        }
    }
}
