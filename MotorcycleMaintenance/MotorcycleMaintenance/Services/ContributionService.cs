using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class ContributionService : IContributionService
    {
        public void CreateReviewNewContribution(DateTime payday, double price, int reviewId)
        {
            StringBuilder insertQuery = new StringBuilder();

            int id = GenerateContributionId();

            insertQuery.Append($"execute procedure insertintocontribution({id},'{payday.ToString("dd.MM.yyyy")}',{price});");
            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertQuery.ToString());

            InsertIntoMapTable(reviewId,id);

        }

        private void InsertIntoMapTable(int reviewId, int contId)
        {
            string insertQuery = $" insert into reviewcontributions(review_id,contribution_id) values({reviewId},{contId});";
            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertQuery);
        }

        public int GenerateContributionId()
        {
            int id = 1;

            if (!HasContributions())
            {
                return id;
            }

            string selectText = " select first 1 id from contribution order by id desc";
            int lastId = int.Parse(CommandExecuter.CommandExecuter.ExecuteString(selectText));

            return ++lastId;
        }

        private bool HasContributions()
        {
            string selectText = "select count(id) from contribution";

            int idsCount = int.Parse(CommandExecuter.CommandExecuter.ExecuteString(selectText));

            return idsCount > 0;
        }

        public void CreateTaxContribution(DateTime payday, double price)
        {
            int contId = GenerateContributionId();

            string insertQuery = $"execute procedure insertintocontribution({contId},'{payday.ToString("dd.MM.yyyy")}',{price});";

            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertQuery);

            int taxId = GetTaxId();

            string insertIntoTaxContQuery = $"insert into taxcontributions values({taxId},{contId});";

            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertIntoTaxContQuery);
        }

        private int GetTaxId()
        {
            string selectText = "select first 1 id from tax order by id desc";

            string lastId = CommandExecuter.CommandExecuter.ExecuteString(selectText);

            return int.Parse(lastId);
        }
    }
}
