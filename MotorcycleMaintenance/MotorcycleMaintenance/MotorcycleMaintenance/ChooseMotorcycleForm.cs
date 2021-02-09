using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.Services;
using MotorcycleMaintenance.Services.Contracts;
using MotorcycleMaintenance.ViewModels;
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
    public partial class ChooseMotorcycleForm : Form
    {
        private readonly IMotorcycleService motorcycleService;
        private MainForm mainForm;

        public ChooseMotorcycleForm(Form callingForm)
        {
            InitializeComponent();
            motorcycleService = new MotorcycleService();
            mainForm = callingForm as MainForm;
        }

        private void ChooseMotorcycleForm_Load(object sender, EventArgs e)
        {
            FormValidation();
            EnterDataIntoDataGrid();
        }

        private void EnterDataIntoDataGrid()
        {
            var userMotorcycles = motorcycleService.GetUserMotorcycles(GlobalVariables.CurrentUserId);

            for (int i = 0; i < userMotorcycles.Count; i++)
            {
                var index = MotorcycleDgv.Rows.Add();
                MotorcycleDgv.Rows[index].Cells[0].Value = userMotorcycles[i].Make;
                MotorcycleDgv.Rows[index].Cells[1].Value = userMotorcycles[i].Model;
                MotorcycleDgv.Rows[index].Cells[2].Value = userMotorcycles[i].MotorcycleId;
                //MotorcycleDgv.Rows.Add(dataGridViewRow);
            }
        }
        
        private void FormValidation()
        {
            if (GlobalVariables.CurrentUserId == -1)
            {
                MessageBox.Show("Only logged in users allowed", GlobalConstants.MessageBoxTopInfo);
                Close();
                return;
            }

            if (!motorcycleService.HasMotorcycles(GlobalVariables.CurrentUserId))
            {
                MessageBox.Show("Empty", GlobalConstants.MessageBoxTopInfo);
                Close();
                return;
            }
        }

        private void MotorcycleDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //get the motorcycle id from datagridview hidden column
            int motorcycleId = 
                int.Parse(MotorcycleDgv.Rows[MotorcycleDgv.CurrentRow.Index].Cells[2].Value.ToString()); ;

            if (!motorcycleService.HasMotorcycle(motorcycleId))
            {
                MessageBox.Show("Invalid motorcycle data",GlobalConstants.MessageBoxTopInfo);
                return;
            }

            UserMotorcycleViewModel model = motorcycleService.GetMotorcycleForMainForm(motorcycleId);
            motorcycleService.SetMotorcycleDataVariables(model);
            mainForm.MotorcycleMakeLabel.Text = model.Make;
            mainForm.MotorcycleModelLabel.Text = model.Model;

            DialogResult dialogResult = MessageBox.Show($"Selected motorcycle is {model.Make} {model.Model}",GlobalConstants.MessageBoxTopInfo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                return;
            }

            MessageBox.Show("Choose Again",GlobalConstants.MessageBoxTopInfo);

        }

        private int GetMotorcycleIdFromDgv()
        {
            int motorcycleDgvRowIndex = MotorcycleDgv.CurrentCell.RowIndex;
            return int.Parse(MotorcycleDgv.Rows[motorcycleDgvRowIndex].Cells[2].Value.ToString());
        }
    }
}
