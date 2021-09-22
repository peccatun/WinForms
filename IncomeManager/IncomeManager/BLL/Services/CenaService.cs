using BLL.InputModels.Cena;
using BLL.Services.Contracts;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CenaService : ICenaService
    {

        public async Task InsertCenaAsync(string inputModelJson)
        {
            CenaInputModel inputModel = JsonConvert.DeserializeObject<CenaInputModel>(inputModelJson);

            double cenaValue = inputModel.Cena;

            string insertStatement = $"insert into cena(is_del, cena_value)values(0, {cenaValue})";

            await CommandExecuter.ExecuteNonQuaryAsync(insertStatement);

            ItemService itemService = new ItemService();

            long itemId = await itemService.GetLastItemIdAsync();
            long cenaId = await GetLastCenaIdAsync();

            CenaItemInputModel cenaItemInputModel = new CenaItemInputModel
            {
                CenaId = cenaId,
                ItemId = itemId,
            };

            await InsertCenaItemAsync(cenaItemInputModel);
        }

        private async Task<long> GetLastCenaIdAsync()
        {
            string selectStatement = "select gen_id(gen_cena_id, 0) from RDB$DATABASE;";

            long lastInsertedCenaId = await CommandExecuter.SelectGenericAsync<long>(selectStatement);

            return lastInsertedCenaId;
        }

        private async Task InsertCenaItemAsync(CenaItemInputModel inputModel)
        {
            long cenaId = inputModel.CenaId;
            long itemId = inputModel.ItemId;

            string insertStatement = $"insert into cena_item(cena_id, item_id)values({cenaId},{itemId})";

            await CommandExecuter.ExecuteNonQuaryAsync(insertStatement);
        }
    }
}
