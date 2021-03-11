using MotorcycleMaintenance.Globals;
using System.Windows.Forms;
using System;

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
            if (GlobalVariables.CurrentBikeId == -1)
            {
                MessageBox.Show("No motorcycle selected");
                return;
            }

            AddMaintenanceForm addMaintenanceForm = new AddMaintenanceForm();
            addMaintenanceForm.Show();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.CurrentBikeId == -1)
            {
                MessageBox.Show("Choose motorcycle firs");
                return;
            }

            new Reports().Show();
        }
    }
}
