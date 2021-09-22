using BLL.InputModels.Category;
using BLL.Services.Contracts;
using BLL.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public async Task AddCategoryAsync(string inputModel)
        {
            AddCategoryInputModel model = JsonConvert.DeserializeObject<AddCategoryInputModel>(inputModel);

            string insertStatement = $"insert into category(is_del, name)values(0, '{model.Name}')";

            await CommandExecuter.ExecuteNonQuaryAsync(insertStatement);
        }

        public async Task<string> GetCategoriesAsync()
        {
            string comboItemsJson = null;

            try
            {
                string selectStatement = $"select c.id, c.name from category c  where c.is_del = 0";

                com.CommandText = selectStatement;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                List<CategoryViewModel> comboItems = new List<CategoryViewModel>();

                using (var reader = await com.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        string id = reader["id"].ToString();
                        string name = reader["name"].ToString();

                        CategoryViewModel comboBoxItemViewModel = new CategoryViewModel
                        {
                            Id = id,
                            Name = name,
                        };

                        comboItems.Add(comboBoxItemViewModel);
                    }
                }

                comboItemsJson = JsonConvert.SerializeObject(comboItems);
            }
            catch (Exception ex)
            {
                //implement logger
            }
            finally
            {
                con.Close();
            }

            return comboItemsJson;
        }
    }
}
