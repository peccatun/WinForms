using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesSystemJupiterSoft.Services
{
    public interface IArticleService
    {
        void CreateArticle(string articleName, decimal articlePrice, string articleCode);

        IEnumerable<string> GetArticles();

        int GetArticleIdByName(string name);
    }
}
