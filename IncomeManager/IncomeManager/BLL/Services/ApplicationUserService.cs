using BLL.InputModels.ApplicationUser;
using BLL.Services.Contracts;
using BLL.ViewModels.ApplicationUser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
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

        public async Task<string> GetApplicationUserListJsonAsync()
        {
            try
            {
                string selectStatement = $"select au.id, au.username from application_user au where au.is_del = 0";

                com.CommandText = selectStatement;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                List<ApplicationUserViewModel> applicationUserList = new List<ApplicationUserViewModel>(); 

                using (var reader = await com.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        string userId = reader["id"].ToString();
                        string username = reader["username"].ToString();

                        ApplicationUserViewModel appUser = new ApplicationUserViewModel
                        {
                            UserId = userId,
                            Username = username
                        };

                        applicationUserList.Add(appUser);
                    }
                }

                string appUserListJson = JsonConvert.SerializeObject(applicationUserList);

                return appUserListJson;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return string.Empty;
        }

        public async Task InsertApplicationUserAsync(string inputModelJson)
        {
            ApplicationUserInputModel inputModel = JsonConvert.DeserializeObject<ApplicationUserInputModel>(inputModelJson);

            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");
            string insertStatement = $"insert into application_user(is_del, username, created_on)values(0,'{inputModel.UserName}', '{currentDate}')";

            await CommandExecuter.ExecuteNonQuaryAsync(insertStatement);
        }
    }
}
