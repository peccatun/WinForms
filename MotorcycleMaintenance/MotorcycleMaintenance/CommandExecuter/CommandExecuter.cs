using MotorcycleMaintenance.Globals;
using System;
using System.Data;
using System.Data.Odbc;
using System.IO;

namespace MotorcycleMaintenance.CommandExecuter
{
    public static class CommandExecuter
    {
        private static readonly OdbcConnection connection;
        private static readonly OdbcCommand command;
        private static readonly Logger.Logger logger;

        static CommandExecuter()
        {
            connection = new OdbcConnection(GlobalConstants.ConnectionsString);
            command = new OdbcCommand("", connection);
            logger = new Logger.Logger();
        }

        public static void ExecuteNonQuery(string query)
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
                logger.LogExceptionText(ex.ToString(),$"ExecuteNonQuery from commant executer problem query:{query}");
            }
            finally
            {
                connection.Close();
            }
        }

        public static string ExecuteString(string query)
        {
            string result = string.Empty;

            try
            {
                command.CommandText = query;

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                result = command.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                logger.LogExceptionText(ex.ToString(),$"ExecuteString from command executer with query:{query}");
            }
            finally
            {
                connection.Close();
            }

            return result;
        }
    }
}
