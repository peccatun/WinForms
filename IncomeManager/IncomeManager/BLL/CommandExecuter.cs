using System;
using System.Data;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace BLL
{
    public static class CommandExecuter
    {


        /// <summary>
        /// Executes save command
        /// </summary>
        /// <param name="executeStatement">execute statement</param>
        /// <returns></returns>
        public static async Task ExecuteNonQuaryAsync(string executeStatement)
        {
            using OdbcConnection con = new OdbcConnection(GlobalConstants.ConnectionString);
            using OdbcCommand com = new OdbcCommand(executeStatement, con);
            await con.OpenAsync();
            await com.ExecuteNonQueryAsync();
        }

        public static async Task<T> SelectGenericAsync<T>(string executeStatement)
        {
            using (OdbcConnection con = new OdbcConnection(GlobalConstants.ConnectionString))
            {
                using (OdbcCommand com = new OdbcCommand(executeStatement, con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    object result = await com.ExecuteScalarAsync();

                    if (result == DBNull.Value || result is null)
                    {
                        throw new NullReferenceException("selected value is null");
                    }

                    return (T)result;
                }
            }
        }
    }
}
