using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.Reviews;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class ReviewService : IReviewService
    {
        private readonly OdbcConnection con;
        private readonly OdbcCommand com;

        public ReviewService()
        {
            con = new OdbcConnection(GlobalConstants.ConnectionsString);
            com = new OdbcCommand(" ", con);
        }

        public void CreateReview(CreateReviewInputModel model)
        {
            StringBuilder InsertIntoReviewQuerySb = new StringBuilder();

            InsertIntoReviewQuerySb.Append($"execute procedure insertintoreview('{model.ReviewedDate}',{model.Price},{model.MotorcycleDataId},'{model.ReviewHeader}',{model.ContributionCount},{model.MonthCount},'{model.InsuranceAgency}','{model.EndDate}');");

            CommandExecuter.CommandExecuter.ExecuteNonQuery(InsertIntoReviewQuerySb.ToString());
        }

        public DateTime GenerateEndDate(DateTime startDate, int months)
        {
            return startDate.AddMonths(months);
        }

        public string GenerateReviewHeader(DateTime reviewedDate)
        {
            string dateString = reviewedDate.ToString();
            StringBuilder dateNumberSb = new StringBuilder();
            dateNumberSb.Append("Застраховка");
            for (int i = 0; i < dateString.Length; i++)
            {
                if (char.IsNumber(dateString[i]))
                {
                    dateNumberSb.Append(dateString[i]);
                }
            }

            return dateNumberSb.ToString(); ;
        }

        public List<string> GetCurrentBikeInsuranceAgensies(int motorcycleId)
        {
            try
            {
                StringBuilder selectAsuranceCompaniesQuerySb = new StringBuilder();
                selectAsuranceCompaniesQuerySb.Append($"select distinct r.insuranceagency from review r where r.motorcycledata_id = {motorcycleId}");

                com.CommandText = selectAsuranceCompaniesQuerySb.ToString();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                List<string> insuranceCompanies = new List<string>();

                using (var reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        insuranceCompanies.Add(reader["insuranceagency"].ToString());
                    }
                }

                return insuranceCompanies;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public bool HasAngecy(int motorcycleId)
        {
            StringBuilder getIdsCountQuerySb = new StringBuilder();
            getIdsCountQuerySb.Append($"select count(id) from review r where r.motorcycledata_id = {motorcycleId}");

            string idsCountString = CommandExecuter.CommandExecuter.ExecuteString(getIdsCountQuerySb.ToString());

            int idsCount = int.Parse(idsCountString);

            return idsCount > 0;
        }
    }
}
