using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.Battery;
using MotorcycleMaintenance.InputModels.FrontBrakes;
using MotorcycleMaintenance.InputModels.Oil;
using MotorcycleMaintenance.InputModels.OilFilter;
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
        private readonly IOilService oilService;
        private readonly IOilFilterService oilFilterService;
        private readonly IFrontBrakesService frontBrakesService;

        public AddMaintenanceForm()
        {
            InitializeComponent();
            batteryService = new BatteryService();
            oilService = new OilService();
            oilFilterService = new OilFilterService();
            frontBrakesService = new FrontBrakesService();
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
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.OilFilter);
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.RearBrake);
            MaintenanceBox.Items.Add(GlobalConstants.MantainanceType.Tires);
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
            if (maintenanceType == GlobalConstants.MantainanceType.Oil)
            {
                CreateNewOil();
            }
            if (maintenanceType == GlobalConstants.MantainanceType.OilFilter)
            {
                CreateNewOilFilter();
            }
            if (maintenanceType == GlobalConstants.MantainanceType.FrontBrakes)
            {
                CreateNewFrontBrakes();
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

        private void CreateNewOil()
        {
            if (!IsMoney(PriceTextBox.Text))
            {
                MessageBox.Show("Price must be a number", GlobalConstants.MessageBoxTopInfo);
                return;
            }

            if (!IsKilometers(KilometersOnChangeTextBox.Text))
            {
                MessageBox.Show("Kilometers must be a number", GlobalConstants.MessageBoxTopInfo);
                return;
            }

            CreateOilInputModel model = new CreateOilInputModel
            {
                Make = MakeTextBox.Text,
                MotorcycleId = GlobalVariables.CurrentBikeId,
                KilometersOnChange = int.Parse(KilometersOnChangeTextBox.Text),
                ChangeDate = ChangeDateDatePicker.Value.ToString("dd.MM.yyyy"),
                Price = double.Parse(PriceTextBox.Text),
            };

            oilService.CreateOil(model);
        }

        private void CreateNewOilFilter()
        {
            if (!IsMoney(PriceTextBox.Text))
            {
                MessageBox.Show("Price must be a number", GlobalConstants.MessageBoxTopInfo);
                return;
            }

            if (!IsKilometers(KilometersOnChangeTextBox.Text))
            {
                MessageBox.Show("Kilometers must be a number", GlobalConstants.MessageBoxTopInfo);
                return;
            }

            OilFilterInputModel model = new OilFilterInputModel
            {
                Make = MakeTextBox.Text,
                MotorcycleId = GlobalVariables.CurrentBikeId,
                KilometersOnChange = int.Parse(KilometersOnChangeTextBox.Text),
                ChangeDate = ChangeDateDatePicker.Value.ToString("dd.MM.yyyy"),
                Price = double.Parse(PriceTextBox.Text),
            };

            oilFilterService.CreateOilFilter(model);
        }

        private void CreateNewFrontBrakes()
        {
            if (!IsMoney(PriceTextBox.Text))
            {
                MessageBox.Show("Price must be a number", GlobalConstants.MessageBoxTopInfo);
                return;
            }

            if (!IsKilometers(KilometersOnChangeTextBox.Text))
            {
                MessageBox.Show("Kilometers must be a number", GlobalConstants.MessageBoxTopInfo);
                return;
            }

            FrontBrakesInputModel model = new FrontBrakesInputModel
            {
                Make = MakeTextBox.Text,
                MotorcycleId = GlobalVariables.CurrentBikeId,
                KilometersOnChange = int.Parse(KilometersOnChangeTextBox.Text),
                ChangeDate = ChangeDateDatePicker.Value.ToString("dd.MM.yyyy"),
                Price = double.Parse(PriceTextBox.Text),
            };

            frontBrakesService.CreateFrontBrakes(model);
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
