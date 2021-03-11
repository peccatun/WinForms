using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.Battery;
using MotorcycleMaintenance.InputModels.BrakeFluid;
using MotorcycleMaintenance.InputModels.Clutch;
using MotorcycleMaintenance.InputModels.Coolant;
using MotorcycleMaintenance.InputModels.FrontBrakes;
using MotorcycleMaintenance.InputModels.MaintenanceService;
using MotorcycleMaintenance.InputModels.Oil;
using MotorcycleMaintenance.InputModels.OilFilter;
using MotorcycleMaintenance.InputModels.RearBrakes;
using MotorcycleMaintenance.InputModels.Tires;
using MotorcycleMaintenance.Services;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MotorcycleMaintenance
{
    public partial class AddMaintenanceForm : Form
    {
        private readonly IOilService oilService;
        private readonly ITiresService tiresService;
        private readonly IClutchService clutchService;
        private readonly ICoolantService coolantService;
        private readonly IBatteryService batteryService;
        private readonly IOilFilterService oilFilterService;
        private readonly IRearBrakesService rearBrakesService;
        private readonly IBrakeFluidService brakeFluidService;
        private readonly IFrontBrakesService frontBrakesService;
        private readonly IMaintenanceService maintenanceService;

        public AddMaintenanceForm()
        {
            InitializeComponent();
            oilService = new OilService();
            tiresService = new TiresService();
            clutchService = new ClutchService();
            batteryService = new BatteryService();
            coolantService = new CoolantService();
            oilFilterService = new OilFilterService();
            brakeFluidService = new BrakeFluidService();
            rearBrakesService = new RearBrakesService();
            frontBrakesService = new FrontBrakesService();
            maintenanceService = new MaintenanceService();
        }

        private void AddMaintenanceForm_Load(object sender, EventArgs e)
        {
            AddMantainanceBoxItems();
        }

        private void AddMantainanceBoxItems()
        {
            maintenanceService.SetMaintenance(MaintenanceBox);
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
                CreateNewOil(maintenanceType);
            }
            if (maintenanceType == GlobalConstants.MantainanceType.OilFilter)
            {
                CreateNewOilFilter();
            }
            if (maintenanceType == GlobalConstants.MantainanceType.FrontBrakes)
            {
                CreateNewFrontBrakes();
            }
            if (maintenanceType == GlobalConstants.MantainanceType.Brakefluid)
            {
                CreateNewBrakeFluid();
            }
            if (maintenanceType == GlobalConstants.MantainanceType.RearBrake)
            {
                CreateNewRearBrakes();
            }
            if (maintenanceType == GlobalConstants.MantainanceType.Clutch)
            {
                CreateNewClutch();
            }
            if (maintenanceType == GlobalConstants.MantainanceType.Tires)
            {
                CreateNewTires();
            }
            if (maintenanceType == GlobalConstants.MantainanceType.Coolant)
            {
                CreateNewCoolant();
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

        private void CreateNewOil(string maintenanceType)
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

            if (maintenanceService.IsNotLast(maintenanceType, model.MotorcycleId))
            {
                CalculationDataModel calcDataModel = maintenanceService.GetCalculationDataModel(maintenanceType, model.MotorcycleId);

                int monthsDriven = maintenanceService.CalculateMonthsDriven(DateTime.ParseExact(model.ChangeDate,"dd.MM.yyyy",CultureInfo.InvariantCulture), calcDataModel.ChangeDate);
                int kilometersDriven = maintenanceService.CalculateKilometersDriven(model.KilometersOnChange, calcDataModel.KilometersOnChange);

                UpdateMaintenanceDataInputModel updateModel = new UpdateMaintenanceDataInputModel
                {
                    KilometersDriven = kilometersDriven,
                    MonthsDriven = monthsDriven,
                    TableName = maintenanceType,
                    MotorcycleId = model.MotorcycleId,
                };

                maintenanceService.SetAdditionalData(updateModel);
            }
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

        private void CreateNewBrakeFluid()
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

            CreateBrakeFluidInputModel model = new CreateBrakeFluidInputModel
            {
                Make = MakeTextBox.Text,
                MotorcycleId = GlobalVariables.CurrentBikeId,
                KilometersOnChange = int.Parse(KilometersOnChangeTextBox.Text),
                ChangeDate = ChangeDateDatePicker.Value.ToString("dd.MM.yyyy"),
                Price = double.Parse(PriceTextBox.Text),
            };

            brakeFluidService.CreateBrakeFluid(model);
        }

        private void CreateNewRearBrakes()
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

            CreateRearBrakesInputModel model = new CreateRearBrakesInputModel
            {
                Make = MakeTextBox.Text,
                MotorcycleId = GlobalVariables.CurrentBikeId,
                KilometersOnChange = int.Parse(KilometersOnChangeTextBox.Text),
                ChangeDate = ChangeDateDatePicker.Value.ToString("dd.MM.yyyy"),
                Price = double.Parse(PriceTextBox.Text),
            };

            rearBrakesService.CreateRearBrakes(model);
        }

        private void CreateNewClutch()
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

            CreateClutchInputModel model = new CreateClutchInputModel
            {
                Make = MakeTextBox.Text,
                MotorcycleId = GlobalVariables.CurrentBikeId,
                KilometersOnChange = int.Parse(KilometersOnChangeTextBox.Text),
                ChangeDate = ChangeDateDatePicker.Value.ToString("dd.MM.yyyy"),
                Price = double.Parse(PriceTextBox.Text),
            };

            clutchService.CreateClutch(model);
        }

        private void CreateNewTires()
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

            CreateTiresInputModel model = new CreateTiresInputModel
            {
                Make = MakeTextBox.Text,
                MotorcycleId = GlobalVariables.CurrentBikeId,
                KilometersOnChange = int.Parse(KilometersOnChangeTextBox.Text),
                ChangeDate = ChangeDateDatePicker.Value.ToString("dd.MM.yyyy"),
                Price = double.Parse(PriceTextBox.Text),
            };

            tiresService.CreateTires(model);
        }

        private void CreateNewCoolant()
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

            CreateCoolantInputModel model = new CreateCoolantInputModel
            {
                Make = MakeTextBox.Text,
                MotorcycleId = GlobalVariables.CurrentBikeId,
                KilometersOnChange = int.Parse(KilometersOnChangeTextBox.Text),
                ChangeDate = ChangeDateDatePicker.Value.ToString("dd.MM.yyyy"),
                Price = double.Parse(PriceTextBox.Text),
            };

            coolantService.CreateCoolant(model);
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
