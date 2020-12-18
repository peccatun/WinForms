using FirebirdSql.Data.FirebirdClient;
using SalesSystemJupiterSoft.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystemJupiterSoft.Services
{
    public class SalesService : ISalesService
    {
        public IEnumerable<DisplaySalesDetailsViewModel> GetSalesForDGV()
        {
            List<DisplaySalesDetailsViewModel> salesDetails = new List<DisplaySalesDetailsViewModel>();

            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();
                StringBuilder fbQuery = new StringBuilder();
                fbQuery.AppendLine("SELECT");
                fbQuery.AppendLine("a.name,");
                fbQuery.AppendLine("s.soldquantity,");
                fbQuery.AppendLine("a.price,");
                fbQuery.AppendLine("s.sumprice,");
                fbQuery.AppendLine("s.solddate");
                fbQuery.AppendLine("FROM Sales as s");
                fbQuery.AppendLine("JOIN Article as a ON s.articleid = a.id");
                fbQuery.AppendLine("ORDER BY s.solddate DESC");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(),fbConnection))
                {
                    using (var reader = fbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DisplaySalesDetailsViewModel model = new DisplaySalesDetailsViewModel
                            {
                                SoldItemName = (string)reader["Name"],
                                SoldQuantity = (int)reader["SoldQuantity"],
                                SoldItemPrice = (decimal)reader["Price"],
                                SoldItemSumPrice = (decimal)reader["SumPrice"],
                                SoldDate = (DateTime)reader["SoldDate"]
                            };

                            salesDetails.Add(model);
                        }
                    }
                }
            }

            return salesDetails;
        }

        public void MakeSale(int articleId, int quantity)
        {
            decimal articlePrice = this.GetArticlePrice(articleId);
            decimal sumPrice = articlePrice * quantity;
            string soldDate = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss");

            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();
                StringBuilder fbQuery = new StringBuilder();
                fbQuery.AppendLine("INSERT INTO Sales(SoldDate,SoldQuantity,SumPrice,ArticleId)");
                fbQuery.AppendLine("VALUES");
                fbQuery.AppendLine($"('{soldDate}',{quantity},{sumPrice},{articleId})");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(),fbConnection))
                {
                    fbCommand.ExecuteNonQuery();
                }
            }
        }

        private decimal GetArticlePrice(int articleId)
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();
                StringBuilder fbQuery = new StringBuilder();
                fbQuery.AppendLine("SELECT a.Price FROM Article as a");
                fbQuery.AppendLine($"WHERE a.Id = {articleId}");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(),fbConnection))
                {
                    decimal price = (decimal)fbCommand.ExecuteScalar();

                    return price;
                }
            }
        }
    }
}
