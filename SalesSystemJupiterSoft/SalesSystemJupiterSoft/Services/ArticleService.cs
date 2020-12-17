using FirebirdSql.Data.FirebirdClient;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystemJupiterSoft.Services
{
    public class ArticleService : IArticleService
    {
        public void CreateArticle(string articleName, decimal articlePrice, string articleCode)
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();

                StringBuilder fbQuery = new StringBuilder();
                fbQuery.AppendLine("INSERT INTO Article(Name,Price,Code)");
                fbQuery.AppendLine("VALUES");
                fbQuery.Append($"('{articleName}',{ articlePrice},'{articleCode}');");

                FbCommand fbCommand = new FbCommand(fbQuery.ToString(),fbConnection);

                fbCommand.ExecuteNonQuery();
            }
        }
    }
}
