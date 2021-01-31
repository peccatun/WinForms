using MotorcycleMaintenance.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcycleMaintenance
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            new NewUserForm().Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            new LogInUserForm().Show();
        }

        private void OutBtn_Click(object sender, EventArgs e)
        {
            GlobalVariables.CurrentUserId = -1;
        }

        private void MotorcycleInfoButton_Click(object sender, EventArgs e)
        {
            new EnterMotorcycleInfoForm().Show();
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            new ChooseMotorcycleForm(this).Show();
        }

        private void AddMaintenanceButton_Click(object sender, EventArgs e)
        {
            AddMaintenanceForm addMaintenanceForm = new AddMaintenanceForm();
            addMaintenanceForm.Show();
        }
    }
}
