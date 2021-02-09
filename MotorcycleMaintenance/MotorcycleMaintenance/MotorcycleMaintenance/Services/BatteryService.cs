using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.Battery;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class BatteryService : IBatteryService
    {
        private OdbcConnection connection;
        private OdbcCommand command;
        private OdbcDataReader reader;

        public BatteryService()
        {
            connection = new OdbcConnection(GlobalConstants.ConnectionsString);
            command = new OdbcCommand(" ", connection);
        }

        /// <summary>
        /// Creates new battery 
        /// </summary>
        /// <param name="model"></param>
        public void CreateBattery(CreateBatteryInputModel model)
        {
            try
            {
                StringBuilder createBatteryQuery = new StringBuilder();

                createBatteryQuery.Append($"execute procedure insertintobattry({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

                command.CommandText = createBatteryQuery.ToString();

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
