using FirebirdSql.Data.FirebirdClient;
using System;
using System.Text;

namespace SalesSystemJupiterSoft.Services
{
    public class InitialDatabaseService : IInitialDatabaseService
    {
        public void CreateInitialDatabase()
        {
            if (ChekIfTablesExist())
            {
                CreateArticleTable();
                CreateArticleIdGenerator();
                SetValueToArticleGenerator();
                CreateArticleIdTrigger();
                CreateSalesTable();
                CreateSalesGenerator();
                SetValueToSalesGenerator();
                CreateSalesIdTrigger();
            }
        }

        public bool ChekIfTablesExist()
        {
            try
            {
                using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
                {
                    fbConnection.Open();

                    StringBuilder fbQuery = new StringBuilder();
                    fbQuery.AppendLine("SELECT * FROM Sales");

                    using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection))
                    {
                        fbCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    return true;
                }
            }

            return false;
        }

        public void CreateArticleIdGenerator()
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();

                StringBuilder fbQuery = new StringBuilder();
                fbQuery.Append("CREATE GENERATOR gen_Article_Id;");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection))
                {
                    fbCommand.ExecuteNonQuery();
                }
            }
        }

        public void CreateArticleIdTrigger()
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();

                StringBuilder fbQuery = new StringBuilder();

                fbQuery.AppendLine("CREATE TRIGGER Article_BI FOR Article");
                fbQuery.AppendLine("ACTIVE BEFORE INSERT POSITION 0");
                fbQuery.AppendLine("AS");
                fbQuery.AppendLine("BEGIN");
                fbQuery.AppendLine("IF(NEW.ID IS NULL) THEN NEW.ID = GEN_ID(GEN_Article_Id,1);");
                fbQuery.AppendLine("END");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection))
                {
                    fbCommand.ExecuteNonQuery();
                }
            }
        }

        public void CreateArticleTable()
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();

                StringBuilder fbQuery = new StringBuilder();

                fbQuery.AppendLine("CREATE TABLE Article(");
                fbQuery.AppendLine("Id INT PRIMARY KEY NOT NULL,");
                fbQuery.AppendLine("Name VARCHAR(50) NOT NULL,");
                fbQuery.AppendLine("Price DECIMAL(18,4) NOT NULL,");
                fbQuery.AppendLine("Code VARCHAR(10)");
                fbQuery.AppendLine(");");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection))
                {
                    fbCommand.ExecuteNonQuery();
                }
            }
        }

        public void CreateSalesGenerator()
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();

                StringBuilder fbQuery = new StringBuilder();

                fbQuery.AppendLine("CREATE GENERATOR gen_Sales_Id;");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection))
                {
                    fbCommand.ExecuteNonQuery();
                }
            }
        }

        public void CreateSalesIdTrigger()
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();

                StringBuilder fbQuery = new StringBuilder();

                fbQuery.AppendLine("CREATE TRIGGER SALES_BI FOR Sales");
                fbQuery.AppendLine("ACTIVE BEFORE INSERT POSITION 0");
                fbQuery.AppendLine("AS");
                fbQuery.AppendLine("BEGIN");
                fbQuery.AppendLine("IF(NEW.ID IS NULL) THEN NEW.ID = GEN_ID(GEN_SALES_ID,1);");
                fbQuery.AppendLine("END");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection))
                {
                    fbCommand.ExecuteNonQuery();
                }
            }
        }

        public void CreateSalesTable()
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();

                StringBuilder fbQuery = new StringBuilder();

                fbQuery.AppendLine("CREATE TABLE Sales(");
                fbQuery.AppendLine("Id INT PRIMARY KEY NOT NULL,");
                fbQuery.AppendLine("SoldDate TIMESTAMP NOT NULL,");
                fbQuery.AppendLine("SoldQuantity INT NOT NULL,");
                fbQuery.AppendLine("SumPrice DECIMAL(18,4) NOT NULL,");
                fbQuery.AppendLine("ArticleId INT NOT NULL,");
                fbQuery.AppendLine("FOREIGN KEY (ArticleId) REFERENCES Article(Id)");
                fbQuery.AppendLine(");");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection))
                {
                    fbCommand.ExecuteNonQuery();
                }
            }
        }

        public void SetValueToArticleGenerator()
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();
                StringBuilder fbQuery = new StringBuilder();

                fbQuery.AppendLine("SET GENERATOR gen_Article_Id TO 0;");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection))
                {
                    fbCommand.ExecuteNonQuery();
                }
            }
        }

        public void SetValueToSalesGenerator()
        {
            using (FbConnection fbConnection = new FbConnection(GlobalConstants.FireBirdConnectionString))
            {
                fbConnection.Open();

                StringBuilder fbQuery = new StringBuilder();
                fbQuery.Append("SET GENERATOR gen_Sales_Id TO 0;");

                using (FbCommand fbCommand = new FbCommand(fbQuery.ToString(), fbConnection))
                {
                    fbCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
