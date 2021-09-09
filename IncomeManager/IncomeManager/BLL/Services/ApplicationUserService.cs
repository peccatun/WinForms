using BLL.InputModels.ApplicationUser;
using BLL.Services.Contracts;
using System;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly OdbcConnection con;
        private readonly OdbcCommand com;

        public ApplicationUserService()
        {
            con = new OdbcConnection(GlobalConstants.ConnectionString);
            com = new OdbcCommand(" ", con);
        }
        public async Task InsertApplicationUserAsync(ApplicationUserInputModel inputModel)
        {
            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");
            string insertStatement = $"insert into application_user(is_del, username, created_on)values(0,'{inputModel.UserName}', '{currentDate}')";

            await CommandExecuter.ExecuteNonQuaryAsync(insertStatement);
        }
    }
}
