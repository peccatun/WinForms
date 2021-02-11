using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.OilFilter;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class OilFilterService : IOilFilterService
    {
        private OdbcConnection connection;
        private OdbcCommand command;

        public OilFilterService()
        {
            connection = new OdbcConnection(GlobalConstants.ConnectionsString);
            command = new OdbcCommand(" ",connection);
        }

        public void CreateOilFilter(OilFilterInputModel model)
        {
            try
            {
                StringBuilder insertIntoOilFilterQuery = new StringBuilder();

                insertIntoOilFilterQuery.Append($"execute procedure InsertIntoOilFilter({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

                command.CommandText = insertIntoOilFilterQuery.ToString();

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
