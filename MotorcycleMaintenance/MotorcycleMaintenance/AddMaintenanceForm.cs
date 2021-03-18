using MotorcycleMaintenance.Enums;
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
using MotorcycleMaintenance.InputModels.Reviews;
using MotorcycleMaintenance.InputModels.Tires;
using MotorcycleMaintenance.Services;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcycleMaintenance
{
    public partial class AddMaintenanceForm : Form
    {
        private readonly Logger.Logger logger;
        private readonly IOilService oilService;
        private readonly ITiresService tiresService;
        private readonly IClutchService clutchService;
        private readonly IReviewService reviewService;
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
            logger = new Logger.Logger();
            oilService = new OilService();
            tiresService = new TiresService();
            clutchService = new ClutchService();
            batteryService = new BatteryService();
            reviewService = new ReviewService();
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
                CreateNewBattery(maintenanceType);
            }
            if (maintenanceType == GlobalConstants.MantainanceType.Oil)
            {
                CreateNewOil(maintenanceType);
            }
            if (maintenanceType == GlobalConstants.MantainanceType.OilFilter)
            {
                CreateNewOilFilter(maintenanceType);
            }
            if (maintenanceType == GlobalConstants.MantainanceType.FrontBrakes)
            {
                CreateNewFrontBrakes(maintenanceType);
            }
            if (maintenanceType == GlobalConstants.MantainanceType.Brakefluid)
            {
                CreateNewBrakeFluid(maintenanceType);
            }
            if (maintenanceType == GlobalConstants.MantainanceType.RearBrake)
            {
                CreateNewRearBrakes(maintenanceType);
            }
            if (maintenanceType == GlobalConstants.MantainanceType.Clutch)
            {
                CreateNewClutch(maintenanceType);
            }
            if (maintenanceType == GlobalConstants.MantainanceType.Tires)
            {
                CreateNewTires(maintenanceType);
            }
            if (maintenanceType == GlobalConstants.MantainanceType.Coolant)
            {
                CreateNewCoolant(maintenanceType);
            }
        }

        private void CreateNewBattery(string maintenanceType)
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

            CreateBatteryInputModel model = new CreateBatteryInputModel
            {
                Make = MakeTextBox.Text,
                MotorcycleId = GlobalVariables.CurrentBikeId,
                KilometersOnChange = int.Parse(KilometersOnChangeTextBox.Text),
                ChangeDate = ChangeDateDatePicker.Value.ToString("dd.MM.yyyy"),
                Price = double.Parse(PriceTextBox.Text),
            };

            batteryService.CreateBattery(model);
            AddKilometersAndMonthsDriven(maintenanceType, model.MotorcycleId, model.ChangeDate, model.KilometersOnChange);

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
            AddKilometersAndMonthsDriven(maintenanceType, model.MotorcycleId, model.ChangeDate, model.KilometersOnChange);
        }


        private void CreateNewOilFilter(string maintenanceType)
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
            AddKilometersAndMonthsDriven(maintenanceType, model.MotorcycleId, model.ChangeDate, model.KilometersOnChange);
        }

        private void CreateNewFrontBrakes(string maintenanceType)
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
            AddKilometersAndMonthsDriven(maintenanceType, model.MotorcycleId, model.ChangeDate, model.KilometersOnChange);
        }

        private void CreateNewBrakeFluid(string maintenanceType)
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
            AddKilometersAndMonthsDriven(maintenanceType, model.MotorcycleId, model.ChangeDate, model.KilometersOnChange);
        }

        private void CreateNewRearBrakes(string maintenanceType)
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
            AddKilometersAndMonthsDriven(maintenanceType, model.MotorcycleId, model.ChangeDate, model.KilometersOnChange);
        }

        private void CreateNewClutch(string maintenanceType)
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
            AddKilometersAndMonthsDriven(maintenanceType, model.MotorcycleId, model.ChangeDate, model.KilometersOnChange);
        }

        private void CreateNewTires(string maintenanceType)
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
            AddKilometersAndMonthsDriven(maintenanceType, model.MotorcycleId, model.ChangeDate, model.KilometersOnChange);
        }

        private void CreateNewCoolant(string maintenanceType)
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
            AddKilometersAndMonthsDriven(maintenanceType, model.MotorcycleId, model.ChangeDate, model.KilometersOnChange);
        }

        private bool IsMoney(string number)
        {
            return double.TryParse(number, out double result);
        }

        private bool IsKilometers(string kilometers)
        {
            return int.TryParse(kilometers, out int result);
        }

        private void AddKilometersAndMonthsDriven(string maintenanceType, int motorcycleId, string changeDate, int kilometersOnChange)
        {
            if (maintenanceService.IsNotLast(maintenanceType, motorcycleId))
            {
                CalculationDataModel calcDataModel = maintenanceService.GetCalculationDataModel(maintenanceType, motorcycleId);

                int monthsDriven = maintenanceService.CalculateMonthsDriven(DateTime.ParseExact(changeDate, "dd.MM.yyyy", CultureInfo.InvariantCulture), calcDataModel.ChangeDate);
                int kilometersDriven = maintenanceService.CalculateKilometersDriven(kilometersOnChange, calcDataModel.KilometersOnChange);

                UpdateMaintenanceDataInputModel updateModel = new UpdateMaintenanceDataInputModel
                {
                    KilometersDriven = kilometersDriven,
                    MonthsDriven = monthsDriven,
                    TableName = maintenanceType,
                    MotorcycleId = motorcycleId,
                };

                maintenanceService.SetAdditionalData(updateModel);
            }
        }

        private void MaintenanceControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaintenanceControl.SelectedTab.Name == "ReviewTab")
            {
                ReviewTabSelectedSettings();
            }
            else
            {
                ReviewTabUnselectedSettings();
            }
        }

        private void ReviewTabSelectedSettings()
        {
            AddMonths();
            AddInsuranceAgency(GlobalVariables.CurrentBikeId);
        }
        private void AddMonths()
        {
            for (int month = 1; month <= 12; month++)
            {
                MounthsCombo.Items.Add(month);
            }
        }

        private void AddInsuranceAgency(int motorcycleId)
        {
            if (reviewService.HasAngecy(motorcycleId))
            {
                var insuranceAgencies = reviewService.GetCurrentBikeInsuranceAgensies(motorcycleId);

                foreach (var angecy in insuranceAgencies)
                {
                    InsuranceAngecyCombo.Items.Add(angecy);
                }
            }
        }

        private void ReviewTabUnselectedSettings()
        {
            ClearReviewTab();
            ClearComboBoxes();
        }

        private void ClearReviewTab()
        {
            OneRadio.Checked = false;
            TwoRadio.Checked = false;
            ThreeRadio.Checked = false;
            FourRadio.Checked = false;
            MounthsCombo.Text = string.Empty;
            ReviewPriceTextBox.Text = string.Empty;
            ReviewNumberComboBox.Text = string.Empty;
            InsuranceAngecyCombo.Text = string.Empty;
            ContribuionPriceTextBox.Text = string.Empty;
        }

        private void ClearComboBoxes()
        {
            InsuranceAngecyCombo.Items.Clear();
            MounthsCombo.Items.Clear();
            ReviewNumberComboBox.Items.Clear();
        }

        private async void AddReviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                throw new ArgumentException("Suck my sock");

                if (string.IsNullOrEmpty(ReviewPriceTextBox.Text) || !IsMoney(ReviewPriceTextBox.Text))
                {
                    MessageBox.Show("Няма цена.");
                    return;
                }

                if (string.IsNullOrEmpty(MounthsCombo.Text))
                {
                    MessageBox.Show("Избери месеци");
                    return;
                }

                short contributionsCount = GetContributionsCount();

                if (contributionsCount == -1)
                {
                    MessageBox.Show("Избери Вноски");
                    return;
                }
                if (string.IsNullOrEmpty(InsuranceAngecyCombo.Text))
                {
                    MessageBox.Show("Попълнете застрахователна агенция!");
                    return;
                }
                if (InsuranceAngecyCombo.Text.Length > 60)
                {
                    MessageBox.Show("Твърде дълго име на застрахователна ангеция!");
                    return;
                }

                short mounthsCount = short.Parse(MounthsCombo.Text);

                CreateReviewInputModel createReviewModel = new CreateReviewInputModel
                {
                    ContributionCount = contributionsCount,
                    MonthCount = mounthsCount,
                    Price = double.Parse(ReviewPriceTextBox.Text),
                    ReviewedDate = ReviewStartDate.Value.ToString("dd.MM.yyyy"),
                    ReviewHeader = reviewService.GenerateReviewHeader(ReviewStartDate.Value),
                    MotorcycleDataId = GlobalVariables.CurrentBikeId,
                    InsuranceAgency = InsuranceAngecyCombo.Text,
                    EndDate = reviewService.GenerateEndDate(ReviewStartDate.Value, mounthsCount).ToString("dd.MM.yyyy"),
                };

                reviewService.CreateReview(createReviewModel);

                await Information("Успешно добавена нова застраховка", InformationType.Success);
            }
            catch (Exception ex)
            {
                logger.LogExceptionText(ex.ToString(),"Batkooo sefte pisha neshto v tiq raboti eiiiiiii mainaaaaaaa");
                await Information("Нещо се обърка. Няма добавена застраховка", InformationType.Error);
            }
        }

        /// <summary>
        /// returns -1 if there isnt any contribution count selected!
        /// </summary>
        /// <returns></returns>
        private short GetContributionsCount()
        {
            short contributionsCount = -1;

            if (OneRadio.Checked)
            {
                contributionsCount = 1;
            }
            else if (TwoRadio.Checked)
            {
                contributionsCount = 2;
            }
            else if (ThreeRadio.Checked)
            {
                contributionsCount = 3;
            }
            else if (FourRadio.Checked)
            {
                contributionsCount = 4;
            }

            return contributionsCount;
        }

        private async Task Information(string informationText, InformationType informationType)
        {
            if (!string.IsNullOrEmpty(InformationLabel.Text))
            {
                InformationLabel.Text = string.Empty;
                Thread.Sleep(100);
            }

            if (informationType == InformationType.Success)
            {
                InformationLabel.ForeColor = Color.Green;
            }
            else if (informationType == InformationType.Warrning)
            {
                InformationLabel.ForeColor = Color.Yellow;
            }
            else if (informationType == InformationType.Error)
            {
                InformationLabel.ForeColor = Color.Red;
            }

            InformationLabel.Text = informationText;

            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1500);
                if (i == 9)
                {
                    InformationLabel.Text = string.Empty;
                    break;
                }
            }

        }
    }
}
