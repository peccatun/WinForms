using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeManager
{
    public partial class AddSellForm : Form
    {
        public AddSellForm()
        {
            InitializeComponent();
        }

        private void btnAddArtikul_Click(object sender, EventArgs e)
        {
            AddArtikulForm addArtikul = new AddArtikulForm();
            addArtikul.Show();
        }
    }
}
