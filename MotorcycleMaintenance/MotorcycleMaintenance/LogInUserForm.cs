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
    public partial class LogInUserForm : Form
    {
        private readonly IUserService userService;

        public LogInUserForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!userService.HasUser(UsernameTextBox.Text))
                {
                    MessageBox.Show("Invalid user", GlobalConstants.MessageBoxTopInfo);
                    return;
                }

                if (!userService.HasPassword(UsernameTextBox.Text,PasswordTextBox.Text))
                {
                    MessageBox.Show("Invalid user", GlobalConstants.MessageBoxTopInfo);
                    return;
                }

                userService.LogInUser(UsernameTextBox.Text);

                string successfullLogIn = $"Successfully logged in as {UsernameTextBox.Text}";

                MessageBox.Show(successfullLogIn, GlobalConstants.MessageBoxTopInfo);
                Close();
            }
            catch (Exception ex)
            {

            }

        }

        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInBtn_Click(sender,e);
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInBtn_Click(sender,e);
            }
        }
    }
}
