using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.Battery;
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
    public partial class AddMaintenanceForm : Form
    {
        private readonly IBatteryService batteryService;

        public AddMaintenanceForm()
        {
            InitializeComponent();
            batteryService = new BatteryService();
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
            CreateNewMaintenance(selectedMaintenance);

            MessageBox.Show("Success", GlobalConstants.MessageBoxTopInfo);
            this.Close();
        }

        private void CreateNewMaintenance(string maintenanceType)
        {
            if (maintenanceType == GlobalConstants.MantainanceType.Battery)
            {
                CreateNewBattery();
            }
        }

        private void CreateNewBattery()
        {
            if (!IsMoney(PriceTextBox.Text))
            {
                MessageBox.Show("Price must be a number",GlobalConstants.MessageBoxTopInfo);
                return;
            }

            if (!IsKilometers(KilometersOnChangeTextBox.Text))
            {
                MessageBox.Show("Kilometers must be a number", GlobalConstants.MessageBoxTopInfo);
                return;
            }

            CreateBatteryInputModel model = new CreateBatteryInputModel
            {
                Make = MakeTextBox.Text,
                MotorcycleId = GlobalVariables.CurrentBikeId,
                KilometersOnChange = int.Parse(KilometersOnChangeTextBox.Text),
                ChangeDate = ChangeDateDatePicker.Value.ToString("dd.MM.yyyy"),
                Price = double.Parse(PriceTextBox.Text),
            };

            batteryService.CreateBattery(model);

        }

        private bool IsMoney(string number)
        {
            return double.TryParse(number, out double result);
        }

        private bool IsKilometers(string kilometers)
        {
            return int.TryParse(kilometers,out int result);
        }

    }
}
