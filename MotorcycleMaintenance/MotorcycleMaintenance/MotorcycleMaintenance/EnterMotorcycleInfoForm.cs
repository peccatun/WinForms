using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels;
using MotorcycleMaintenance.Services;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcycleMaintenance
{
    public partial class EnterMotorcycleInfoForm : Form
    {
        private readonly IMotorcycleService motorcycleService;

        public EnterMotorcycleInfoForm()
        {
            InitializeComponent();
            motorcycleService = new MotorcycleService();
        }

        private void EnterInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MakeTextBox.Text.Length > 30)
                {
                    MessageBox.Show("Make max lenght is 30", GlobalConstants.MessageBoxTopInfo);
                    return;
                }
                if (string.IsNullOrEmpty(MakeTextBox.Text))
                {
                    MessageBox.Show("No make info!!!", GlobalConstants.MessageBoxTopInfo);
                    return;
                }
                if (ModelTextBox.Text.Length > 50)
                {
                    MessageBox.Show("Model max lenght is 50", GlobalConstants.MessageBoxTopInfo);
                    return;
                }
                if (string.IsNullOrEmpty(ModelTextBox.Text))
                {
                    MessageBox.Show("No model info!!!", GlobalConstants.MessageBoxTopInfo);
                    return;
                }
                if (!IsNumber(KilometersTextBox.Text))
                {
                    MessageBox.Show("Kilometers must be a number", GlobalConstants.MessageBoxTopInfo);
                    return;
                }
                if (string.IsNullOrEmpty(KilometersTextBox.Text))
                {
                    MessageBox.Show("No Kilometers info!!!", GlobalConstants.MessageBoxTopInfo);
                    return;
                }

                motorcycleService.EnterMotorcycleInfo(GetModelInfo());
                MessageBox.Show("success", GlobalConstants.MessageBoxTopInfo);
                Close();
            }
            catch (Exception ex)
            {

            }

        }

        private bool IsNumber(string number)
        {
            return int.TryParse(number, out int isNuber);
        }

        private MotorcycleInfoInputModel GetModelInfo()
        {
            return new MotorcycleInfoInputModel
            {
                CreationDate = DateTime.Parse(CreationDate.Text.ToString(),
                CultureInfo.CreateSpecificCulture("es-ES")),
                Kilometers = int.Parse(KilometersTextBox.Text),
                Make = MakeTextBox.Text,
                Model = ModelTextBox.Text,
                UserId = GlobalVariables.CurrentUserId,
            };
        }

        private void EnterMotorcycleInfoForm_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.CurrentUserId == -1)
            {
                MessageBox.Show("Only logged users allowed",GlobalConstants.MessageBoxTopInfo);
                Close();
            }
        }
    }
}
