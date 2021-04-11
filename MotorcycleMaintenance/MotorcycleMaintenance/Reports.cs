using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.Services;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcycleMaintenance
{
    public partial class Reports : Form
    {
        private readonly IMaintenanceService maintenanceService;
        private readonly Logger.Logger logger;
        private readonly OdbcConnection con;
        private readonly OdbcCommand com;

        public Reports()
        {
            InitializeComponent();
            logger = new Logger.Logger();
            maintenanceService = new MaintenanceService();
            con = new OdbcConnection(GlobalConstants.ConnectionsString);
            com = new OdbcCommand(" ", con);
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            maintenanceService.SetMaintenance(MaintenanceType);
        }

        private void MakeReportBtn_Click(object sender, EventArgs e)
        {
            string maintenanceType = MaintenanceType.Text;

            StringBuilder selectInfoQuerySb = new StringBuilder();

            selectInfoQuerySb.Append($"select * from {maintenanceType} t ");

            if (maintenanceType == GlobalConstants.MantainanceType.OilFilter)
            {
                selectInfoQuerySb.Append($" where t.motorcycle_id = {GlobalVariables.CurrentBikeId}");
            }
            else
            {
                selectInfoQuerySb.Append($" where t.motorcycledata_id = {GlobalVariables.CurrentBikeId}");
            }

            selectInfoQuerySb.Append(" order by t.ChangeDate asc ");

            MaintenanceInfoGrid.Rows.Clear();
            FillDataGridInfo(selectInfoQuerySb.ToString());
        }

        private void FillDataGridInfo(string query)
        {
            try
            {
                com.CommandText = query;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (var reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int index = MaintenanceInfoGrid.Rows.Add();

                        MaintenanceInfoGrid.Rows[index].Cells[0].Value = reader["id"].ToString();
                        MaintenanceInfoGrid.Rows[index].Cells[1].Value = reader["ChangeDate"].ToString();
                        MaintenanceInfoGrid.Rows[index].Cells[2].Value = reader["Price"].ToString();
                        MaintenanceInfoGrid.Rows[index].Cells[3].Value = reader["Make"].ToString();
                        MaintenanceInfoGrid.Rows[index].Cells[4].Value = reader["MonthsDriven"].ToString();
                        MaintenanceInfoGrid.Rows[index].Cells[5].Value = reader["KilometersDriven"].ToString();
                        MaintenanceInfoGrid.Rows[index].Cells[6].Value = reader["KilometersOnChange"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogExceptionText(ex.ToString(),$"Thrown in reports with query:{query}, towa se e sluchilo kogato si se opital da pylnish datagrida");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
