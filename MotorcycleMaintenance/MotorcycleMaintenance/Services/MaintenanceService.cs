using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.MaintenanceService;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;
using System.Windows.Forms;

namespace MotorcycleMaintenance.Services
{
    public class MaintenanceService : IMaintenanceService
    {

        private readonly OdbcConnection con;
        private readonly OdbcCommand com;

        public MaintenanceService()
        {
            con = new OdbcConnection(GlobalConstants.ConnectionsString);
            com = new OdbcCommand(" ", con);
        }

        public int CalculateMonthsDriven(DateTime currentDateTime, DateTime oldDateTime)
        {
            int currentDateYear = int.Parse(currentDateTime.Year.ToString());
            int currentDateMonth = int.Parse(currentDateTime.Month.ToString());
            int oldDateYear = int.Parse(oldDateTime.Year.ToString());
            int oldDateMontn = int.Parse(oldDateTime.Month.ToString());

            int result = 0;

            for (int i = 1; i < 100000000; i++)
            {
                if (oldDateYear == currentDateYear)
                {
                    if (oldDateMontn == currentDateMonth)
                    {
                        result = i;
                        break;
                    }
                }

                if (oldDateMontn == 12)
                {
                    oldDateYear++;
                    oldDateMontn = 1;
                }

                oldDateMontn++;
            }

            return result;
        }

        public void FillDataGridInformation(string maintenanceType, ref DataGridView dataGrid)
        {
            try
            {
                StringBuilder selectInfoQuerySb = new StringBuilder();

                selectInfoQuerySb.Append($"select * from {maintenanceType} t ");

                if (maintenanceType == GlobalConstants.MantainanceType.OilFilter)
                {
                    selectInfoQuerySb.Append($" where t.motorcycle_id = {GlobalVariables.CurrentBikeId}");
                }

                selectInfoQuerySb.Append($" where t.motorcycledata_id = 5");

                com.CommandText = selectInfoQuerySb.ToString();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (var reader = com.ExecuteReader())
                {
                    int gridRow = 0;

                    while (reader.Read())
                    {
                        dataGrid.Rows.Add();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dataGrid.Rows[gridRow].Cells[i].Value = reader[i].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public bool IsNotLast(string tableName, int motorcyckeId)
        {
            try
            {
                StringBuilder selectTableIdCounQuerySb = new StringBuilder();

                selectTableIdCounQuerySb.Append($"select count(t.id) from {tableName} t ");

                if (tableName == GlobalConstants.MantainanceType.OilFilter)
                {
                    selectTableIdCounQuerySb.Append($" where t.motorcycle_id = {motorcyckeId} ");
                }
                else
                {
                    selectTableIdCounQuerySb.Append($" where t.motorcycledata_id = {motorcyckeId}");
                }

                int idCount = int.Parse(CommandExecuter.CommandExecuter.ExecuteString(selectTableIdCounQuerySb.ToString()));

                return idCount > 1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void SetMaintenance(ComboBox comboBox)
        {
            comboBox.Items.Add(GlobalConstants.MantainanceType.Battery);
            comboBox.Items.Add(GlobalConstants.MantainanceType.Brakefluid);
            comboBox.Items.Add(GlobalConstants.MantainanceType.Clutch);
            comboBox.Items.Add(GlobalConstants.MantainanceType.Coolant);
            comboBox.Items.Add(GlobalConstants.MantainanceType.FrontBrakes);
            comboBox.Items.Add(GlobalConstants.MantainanceType.Oil);
            comboBox.Items.Add(GlobalConstants.MantainanceType.OilFilter);
            comboBox.Items.Add(GlobalConstants.MantainanceType.RearBrake);
            comboBox.Items.Add(GlobalConstants.MantainanceType.Tires);
        }

        public CalculationDataModel GetCalculationDataModel(string tableName, int motorcycleId)
        {
            try
            {
                StringBuilder selectQuerySb = new StringBuilder();

                selectQuerySb.Append($"select first 1 skip 1 t.kilometersonchange, t.changedate from {tableName} t ");

                if (tableName == GlobalConstants.MantainanceType.OilFilter)
                {
                    selectQuerySb.Append($" where t.motorcycle_id = {GlobalVariables.CurrentBikeId} ");
                }
                else
                {
                    selectQuerySb.Append($" where t.motorcycledata_id = {GlobalVariables.CurrentBikeId} ");
                }

                selectQuerySb.Append($" order by t.changedate desc ");

                com.CommandText = selectQuerySb.ToString();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                CalculationDataModel calculationDataModel = new CalculationDataModel();

                using (var reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        calculationDataModel.ChangeDate = DateTime.Parse(reader["changedate"].ToString());
                        calculationDataModel.KilometersOnChange = int.Parse(reader["kilometersonchange"].ToString());
                    }
                }

                return calculationDataModel;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public int CalculateKilometersDriven(int currentKilometersDriven, int lastKilometersDriven)
        {
            int result = currentKilometersDriven - lastKilometersDriven;

            return result;
        }

        public void SetAdditionalData(UpdateMaintenanceDataInputModel model)
        {
            StringBuilder updateQuery = new StringBuilder();

            updateQuery.Append($"update {model.TableName} t ");
            updateQuery.Append($" set t.monthsdriven = {model.MonthsDriven} , t.kilometersdriven = {model.KilometersDriven} ");

            int recordId = GetLastRecordId(model.TableName, model.MotorcycleId);

            updateQuery.Append($" where t.id = {recordId} ");

            CommandExecuter.CommandExecuter.ExecuteNonQuery(updateQuery.ToString());
        }

        private int GetLastRecordId(string tableName, int motorcycleId)
        {
            StringBuilder query = new StringBuilder();

            query.Append("select first 1 t.id ");
            query.Append($" from {tableName} t ");


            if (tableName == GlobalConstants.MantainanceType.OilFilter)
            {
                query.Append($" where t.motorcycle_id = {motorcycleId} ");
            }
            else
            {
                query.Append($" where t.motorcycledata_id = {motorcycleId} ");
            }

            query.Append(" order by t.changedate desc");

            int result = int.Parse(CommandExecuter.CommandExecuter.ExecuteString(query.ToString()));

            return result;
        }
    }
}
