using BLL.InputModels.Cena;
using BLL.InputModels.Item;
using BLL.Services.Contracts;
using BLL.ViewModels.Item;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ItemService : IItemService
    {
        private readonly ICenaService cenaService;

        private readonly OdbcConnection con;
        private readonly OdbcCommand com;

        public ItemService()
        {
            cenaService = new CenaService();

            con = new OdbcConnection(GlobalConstants.ConnectionString);
            com = new OdbcCommand(" ", con);
        }

        public async Task InsertItemAsync(string inputModelJson)
        {
            ItemInputModel inputModel = JsonConvert.DeserializeObject<ItemInputModel>(inputModelJson);

            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");
            long categoryId = inputModel.CategoryId;
            string name = inputModel.Name;

            string insertStatement = $"insert into item(is_del, created_on, category_id, name)values(0,'{currentDate}', {categoryId}, '{name}')";

            await CommandExecuter.ExecuteNonQuaryAsync(insertStatement);

            double price = inputModel.Price;

            CenaInputModel cenaInputModel = new CenaInputModel
            {
                Cena = price,
            };

            string cenaInputModelJson = JsonConvert.SerializeObject(cenaInputModel);

            await cenaService.InsertCenaAsync(cenaInputModelJson);
        }

        public async Task<long> GetLastItemIdAsync()
        {
            string selectStatement = "select gen_id(gen_item_id, 0) from RDB$DATABASE;";

            long nextItemId = await CommandExecuter.SelectGenericAsync<long>(selectStatement);

            return nextItemId;
        }

        public async Task<string> GetItemListJsonAsync()
        {
            try
            {
                string selectStatement = "select i.id, i.name from item i where i.is_del = 0";

                com.CommandText = selectStatement;

                if (con.State == ConnectionState.Closed)
                {
                    await con.OpenAsync();
                }

                List<ItemViewModel> itemList = new List<ItemViewModel>();

                using (var reader = await com.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        string itemId = reader["id"].ToString();
                        string name = reader["name"].ToString();

                        ItemViewModel itemViewModel = new ItemViewModel
                        {
                            itemId = itemId,
                            Name = name,
                        };

                        itemList.Add(itemViewModel);
                    }
                }

                string itemListJson = JsonConvert.SerializeObject(itemList);

                return itemListJson;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}


