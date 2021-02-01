using MotorcycleMaintenance.Globals;
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
    public partial class AddMaintenanceForm : Form
    {
        public AddMaintenanceForm()
        {
            InitializeComponent();
        }

        private void AddMaintenanceForm_Load(object sender, EventArgs e)
        {
            AddMantainanceBoxItems();
        }



        private void AddMantainanceBoxItems()
        {
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.Battery);
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.Brakefluid);
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.Clutch);
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.Coolant);
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.FrontBrakes);
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.Oil);
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.RearBrake);
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.Tires);
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.OilFilter);
        }

        private void AddMaintenanceBtn_Click(object sender, EventArgs e)
        {

            string selectedMaintenance = MaintenanceBox.SelectedItem.ToString();

        }

        private void CreateNewBattery()
        {
            if (!IsMoney(PriceTextBox.Text))
            {
                MessageBox.Show("Price must be a number",GlobalConstants.MessageBoxTopInfo);
                return;
            }

        }

        private void CreateNewMaintenance(string maintenanceType)
        {
            if (maintenanceType == GlobalConstants.MantainanceType.Battery)
            {
                CreateNewBattery();
            }
        }

        private bool IsMoney(string number)
        {
            return double.TryParse(number, out double result);
        }


    }
}
