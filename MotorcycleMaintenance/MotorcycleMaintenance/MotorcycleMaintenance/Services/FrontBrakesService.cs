using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.FrontBrakes;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class FrontBrakesService : IFrontBrakesService
    {
        private OdbcConnection connection;
        private OdbcCommand command;

        public FrontBrakesService()
        {
            connection = new OdbcConnection(GlobalConstants.ConnectionsString);
            command = new OdbcCommand(" ", connection);
        }

        public void CreateFrontBrakes(FrontBrakesInputModel model)
        {
            try
            {
                StringBuilder insertIntoFrontBrakesQuery = new StringBuilder();

                insertIntoFrontBrakesQuery
                    .Append($"execute procedure InsertIntoFrontBrakes({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

                command.CommandText = insertIntoFrontBrakesQuery.ToString();

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
