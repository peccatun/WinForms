using SalesSystemJupiterSoft.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesSystemJupiterSoft
{
    public partial class SalesReferenceForm : Form
    {
        private readonly ISalesService salesService;

        public SalesReferenceForm()
        {
            InitializeComponent();
            salesService = (ISalesService)Program.ServiceProvider.GetService(typeof(ISalesService));
        }

        private void BackToMenuFromReferencesBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MakeReferenceBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = DateTime.Parse(FromDatePicker.Text);
            DateTime toDate = DateTime.Parse(ToDatePicker.Text);

            dataGridView1.DataSource = salesService.GetSalesReference(fromDate,toDate);
        }
    }
}
