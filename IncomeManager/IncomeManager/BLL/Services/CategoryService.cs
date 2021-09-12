using BLL.InputModels.Category;
using BLL.Services.Contracts;
using BLL.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly OdbcConnection con;
        private readonly OdbcCommand com;

        public CategoryService()
        {
            con = new OdbcConnection(GlobalConstants.ConnectionString);
            com = new OdbcCommand(" ", con);
        }

        public async Task AddCategory(AddCategoryInputModel model)
        {
            string insertStatement = $"insert into category(is_del, name)values(0, '{model.Name}')";

            await CommandExecuter.ExecuteNonQuaryAsync(insertStatement);
        }

        public async Task<List<ComboBoxItemViewModel>> GetCategoriesAsync()
        {
            List<ComboBoxItemViewModel> comboItems = null;

            try
            {
                string selectStatement = $"select c.id, c.name from category c  where c.is_del = 0";

                com.CommandText = selectStatement;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                comboItems = new List<ComboBoxItemViewModel>();

                using (var reader = await com.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        string key = reader["name"].ToString();
                        string value = reader["id"].ToString();

                        ComboBoxItemViewModel comboBoxItemViewModel = new ComboBoxItemViewModel
                        {
                            Key = key,
                            Value = value,
                        };

                        comboItems.Add(comboBoxItemViewModel);
                    }
                }
            }
            catch (Exception ex)
            {
                //implement logger
            }
            finally
            {
                con.Close();
            }

            return comboItems;
        }
    }
}
