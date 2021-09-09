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
    }
}
