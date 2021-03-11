using MotorcycleMaintenance.Globals;
using System;
using System.Data;
using System.Data.Odbc;

namespace MotorcycleMaintenance.CommandExecuter
{
    public static class CommandExecuter
    {
        private static readonly OdbcConnection connection;
        private static readonly OdbcCommand command;

        static CommandExecuter()
        {
            connection = new OdbcConnection(GlobalConstants.ConnectionsString);
            command = new OdbcCommand("", connection);
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

            }
            finally
            {
                connection.Close();
            }
        }

        public static string ExecuteString(string query)
        {
            try
            {
                command.CommandText = query;

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string result = command.ExecuteScalar().ToString();

                return result;
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

        public static OdbcDataReader ExecuteReader(string query)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.CommandText = query;

                OdbcDataReader odbcDataReader = command.ExecuteReader();

                return odbcDataReader;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return null;
        }
    }
}
