using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesSystemJupiterSoft
{
    public partial class MakeASaleForm : Form
    {
        public MakeASaleForm()
        {
            InitializeComponent();
        }

        private void BackToMenuFromSalesBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
