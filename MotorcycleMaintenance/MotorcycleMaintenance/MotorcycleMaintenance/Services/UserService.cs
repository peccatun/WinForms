using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class UserService : IUserService
    {
        private readonly OdbcConnection connection;
        private readonly OdbcCommand command;

        public UserService()
        {
            connection = new OdbcConnection(GlobalConstants.ConnectionsString);
            command = new OdbcCommand(" ", connection);
        }

        public void CreateUser(string username, string password)
        {
            try
            {
                StringBuilder createUserQuerySb = new StringBuilder();

                createUserQuerySb.Append("insert into users(username,password)");
                createUserQuerySb.Append($"values ('{username}','{password}')");

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.CommandText = createUserQuerySb.ToString();
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

        public int GetUserId(string username)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                StringBuilder getUserIdQuerySb = new StringBuilder();

                getUserIdQuerySb.Append($"select id from users where username = '{username}'");

                command.CommandText = getUserIdQuerySb.ToString();

                int userId = int.Parse(command.ExecuteScalar().ToString());

                return userId;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool HasPassword(string username, string password)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                StringBuilder getUserIdCountSb = new StringBuilder();

                getUserIdCountSb.Append($"select count(u.id) from users u where u.username = '{username}' and u.password = '{password}'");

                command.CommandText = getUserIdCountSb.ToString();

                int userIdCount = int.Parse(command.ExecuteScalar().ToString());

                if (userIdCount < 1)
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool HasUser(string username)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                StringBuilder getUserIdCountSb = new StringBuilder();

                getUserIdCountSb.Append($"select count(u.id) from users u where u.username = '{username}'");
                command.CommandText = getUserIdCountSb.ToString();

                int userIdCount = int.Parse(command.ExecuteScalar().ToString());

                if (userIdCount < 1)
                {
                    return false;
                }

                return true;
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

        public void LogInUser(string username)
        {
            int userId = GetUserId(username);

            GlobalVariables.CurrentUserId = userId;
        }

        public void LogOutUser()
        {
            GlobalVariables.CurrentUserId = -1;
        }
    }
}
