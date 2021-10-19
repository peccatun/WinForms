using InsertORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInsertORM
{
    public partial class Form1 : Form
    {
        private readonly InsertStatementGenerator insertTable;

        public Form1()
        {
            InitializeComponent();
            insertTable = new InsertStatementGenerator();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Brak inputModel3 = new Brak
            {
                Comment = "Comment",
                Data = DateTime.Now.ToString("dd.MM.yyyy"),
                IsDel = 0,
                MagaziniFk = 1,
                Pk = 10000,
                RegNumber = "0R10000",
                SkladoveFk = 1,
                SlujiteliFk = 1,
                Time = DateTime.Now.ToString("HH:mm:ss"),
            };

            insertTable.InsertTableRow(inputModel3);

            PotrebiteliGrupi inputModel2 = new PotrebiteliGrupi
            {
                Ime = "Petko",
                IsDel = 0,
                Komentar = "Komentar",
                Pk = 45345,
                RegNumber = "0R45345",
                Zabelejka = "Zabelejka",
            };

            insertTable.InsertTableRow(inputModel2);

            ProizvodstvoList inputModel = new ProizvodstvoList
            {
                IsDel = 0,
                Kolichestvo = 1.55,
                Pk = 1000000,
                ProizovdstoProduktiFk = 100,
                ProizvodstvoFk = 100,
                RegNumber = "0R1000000",
                SerienNomer = "SerNomer",
                SkldoveFk = 1,
                StokiFk = 15,
                StokiMerniEdFk = 15,
                ZabelejkaBatkaName = "Zabelejka"

            };

            insertTable.InsertTableRow(inputModel);


        }
    }
}
