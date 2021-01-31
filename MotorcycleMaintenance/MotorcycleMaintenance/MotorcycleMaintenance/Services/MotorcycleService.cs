using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels;
using MotorcycleMaintenance.Services.Contracts;
using MotorcycleMaintenance.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class MotorcycleService : IMotorcycleService
    {
        private readonly OdbcConnection connection;
        private readonly OdbcCommand command;
        private OdbcDataReader reader;

        public MotorcycleService()
        {
            connection = new OdbcConnection(GlobalConstants.ConnectionsString);
            command = new OdbcCommand(" ", connection);
        }

        public void EnterMotorcycleInfo(MotorcycleInfoInputModel model)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }


                StringBuilder insertMotorcycleInfoQuerySb = new StringBuilder();
                insertMotorcycleInfoQuerySb
                    .Append($" insert into motorcycledata(make,model,kilometers,creationdate,user_id) ");
                insertMotorcycleInfoQuerySb.Append(" values ");
                insertMotorcycleInfoQuerySb.Append($" ('{model.Make}','{model.Model}','{model.Kilometers}','{model.CreationDate.Date.ToString("d")}','{model.UserId}'); ");

                command.CommandText = insertMotorcycleInfoQuerySb.ToString();
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

        public UserMotorcycleViewModel GetMotorcycleForMainForm(int motorcycleId)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                StringBuilder getMotorcycleInfoQuery = new StringBuilder();

                getMotorcycleInfoQuery.Append(" select md.id, md.make, md.model ");
                getMotorcycleInfoQuery.Append(" from motorcycledata md ");
                getMotorcycleInfoQuery.Append($" where md.id = {motorcycleId} ");

                command.CommandText = getMotorcycleInfoQuery.ToString();

                UserMotorcycleViewModel model = new UserMotorcycleViewModel();
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        model.MotorcycleId = int.Parse(reader["id"].ToString());
                        model.Make = reader["make"].ToString();
                        model.Model = reader["model"].ToString();
                    }
                }

                return model;
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

        public List<UserMotorcycleViewModel> GetUserMotorcycles(int userId)
        {
            try
            {
                StringBuilder getUserMotorcyclesQuerySb = new StringBuilder();
                getUserMotorcyclesQuerySb.Append(" select md.id, md.make, md.model ");
                getUserMotorcyclesQuerySb.Append(" from motorcycledata md ");
                getUserMotorcyclesQuerySb.Append($" where md.user_id = {userId} ");

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.CommandText = getUserMotorcyclesQuerySb.ToString();

                List<UserMotorcycleViewModel> userMotorcycles = new List<UserMotorcycleViewModel>();

                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserMotorcycleViewModel model = new UserMotorcycleViewModel
                        {
                            Make = reader["Make"].ToString(),
                            Model = reader["Model"].ToString(),
                            MotorcycleId = int.Parse(reader["id"].ToString()),
                        };

                        userMotorcycles.Add(model);
                    }
                }

                return userMotorcycles;
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

        public bool HasMotorcycle(int motorcycleId)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                StringBuilder getMotorcycleIdCountQuery = new StringBuilder();

                getMotorcycleIdCountQuery
                    .Append($"select count(md.id) from motorcycledata md where md.id = {motorcycleId}");

                command.CommandText = getMotorcycleIdCountQuery.ToString();

                return (int.Parse(command.ExecuteScalar().ToString())) > 0;
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

        public bool HasMotorcycles(int userId)
        {
            try
            {
                StringBuilder hasMotorcycleQuerySb = new StringBuilder();

                hasMotorcycleQuerySb
                    .Append($" select count(md.id) from motorcycledata md where md.user_id = {userId} ");

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.CommandText = hasMotorcycleQuerySb.ToString();

                return (int.Parse(command.ExecuteScalar().ToString())) > 0;

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

        public void SetMotorcycleDataVariables(UserMotorcycleViewModel model)
        {
            GlobalVariables.CurrentBikeId = model.MotorcycleId;
            GlobalVariables.CurrentMotorcycleMake = model.Make;
            GlobalVariables.CurrentMotorcycleModel = model.Model;
        }
    }
}
