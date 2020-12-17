using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystemJupiterSoft
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void EnterArticleBtn_Click(object sender, EventArgs e)
        {
            EnterArticleForm enterArticleForm = new EnterArticleForm();
            enterArticleForm.Tag = this;
            enterArticleForm.Show(this);
        }

        private void MakeSaleBtn_Click(object sender, EventArgs e)
        {
            MakeASaleForm makeASaleForm = new MakeASaleForm();
            makeASaleForm.Tag = this;
            makeASaleForm.Show(this);
        }

        private void SalesReferenceBtn_Click(object sender, EventArgs e)
        {
            SalesReferenceForm salesReferenceForm = new SalesReferenceForm();
            salesReferenceForm.Tag = this;
            salesReferenceForm.Show(this);
        }
    }
}
