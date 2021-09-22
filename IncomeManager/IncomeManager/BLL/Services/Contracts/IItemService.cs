using System.Threading.Tasks;

namespace BLL.Services.Contracts
{
    public interface IItemService
    {
        Task InsertItemAsync(string inputModelJson);

        Task<long> GetLastItemIdAsync();

        Task<string> GetItemListJsonAsync();
    }
}
