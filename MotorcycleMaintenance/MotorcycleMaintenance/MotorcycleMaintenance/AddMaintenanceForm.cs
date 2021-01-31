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
            MantainanceBox.Items.Add(GlobalConstants.MantainanceType.Battery);
            MantainanceBox.Items.Add(GlobalConstants.MantainanceType.Brakefluid);
            MantainanceBox.Items.Add(GlobalConstants.MantainanceType.Clutch);
            MantainanceBox.Items.Add(GlobalConstants.MantainanceType.Coolant);
            MantainanceBox.Items.Add(GlobalConstants.MantainanceType.FrontBrakes);
            MantainanceBox.Items.Add(GlobalConstants.MantainanceType.Oil);
            MantainanceBox.Items.Add(GlobalConstants.MantainanceType.RearBrake);
            MantainanceBox.Items.Add(GlobalConstants.MantainanceType.Tires);
            MantainanceBox.Items.Add(GlobalConstants.MantainanceType.OilFilter);

        }
    }
}
