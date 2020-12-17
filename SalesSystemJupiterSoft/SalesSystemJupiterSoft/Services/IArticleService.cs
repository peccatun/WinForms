using System.Threading.Tasks;

namespace SalesSystemJupiterSoft.Services
{
    public interface IArticleService
    {
        void CreateArticle(string articleName, decimal articlePrice, string articleCode);
    }
}
