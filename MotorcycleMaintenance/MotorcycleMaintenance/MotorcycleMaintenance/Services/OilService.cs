using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.Oil;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class OilService : IOilService
    {
        private OdbcConnection connection;
        private OdbcCommand command;

        public OilService()
        {
            connection = new OdbcConnection(GlobalConstants.ConnectionsString);
            command = new OdbcCommand(" ", connection);
        }

        /// <summary>
        /// Creates new oil 
        /// </summary>
        /// <param name="model"></param>
        public void CreateOil(CreateOilInputModel model)
        {
            try
            {
                StringBuilder insertIntoOilQuery = new StringBuilder();

                insertIntoOilQuery.Append($"execute procedure InsertIntoOil({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

                command.CommandText = insertIntoOilQuery.ToString();

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
