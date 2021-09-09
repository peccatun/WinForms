using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.InputModels.ApplicationUser;
using BLL.Services;
using BLL.Services.Contracts;

namespace IncomeManager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(this);
            addUserForm.Show();
            WindowState = FormWindowState.Minimized;
        }
    }
}
