using MotorcycleMaintenance.CommandExecuter.Contracts;
using MotorcycleMaintenance.Globals;
using System;
using System.Data;
using System.Data.Odbc;

namespace MotorcycleMaintenance.CommandExecuter
{
    public class CommandExecuter : ICommandExecuter
    {

        private readonly OdbcConnection connection;
        private readonly OdbcCommand command;

        public CommandExecuter()
        {
            connection = new OdbcConnection(GlobalConstants.ConnectionsString);
            command = new OdbcCommand(" ",connection);
        }
        public void ExecuteNonQuery(string query)
        {
            try
            {
                command.CommandText = query;

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
