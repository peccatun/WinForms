using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
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
                fbQuery.Append($"('{articleName}',{articlePrice},'{articleCode}');");

                FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection);

                fbCommand.ExecuteNonQuery();
            }
        }

        public IEnumerable<string> GetArticles()
        {
            List<string> articles = new List<string>();

            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();

                StringBuilder fbQuery = new StringBuilder();
                fbQuery.AppendLine("SELECT Name FROM Article");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection))
                {
                    using (var reader = fbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            articles.Add((string)reader["Name"]);
                        }
                    }
                }
            }

            return articles;
        }

        public int GetArticleIdByName(string name)
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();

                StringBuilder fbQuery = new StringBuilder();
                fbQuery.AppendLine("SELECT Id FROM Article");
                fbQuery.AppendLine($"WHERE Name = '{name}'");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(),fbConnection))
                {
                    int articleId = (int)fbCommand.ExecuteScalar();

                    return articleId;
                }
            }
        }
    }
}
