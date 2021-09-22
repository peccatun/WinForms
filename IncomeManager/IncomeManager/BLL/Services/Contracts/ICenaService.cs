using System.Threading.Tasks;

namespace BLL.Services.Contracts
{
    public interface ICenaService
    {
        Task InsertCenaAsync(string inputModelJson);
    }
}
