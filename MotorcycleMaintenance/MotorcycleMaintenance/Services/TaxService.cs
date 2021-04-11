using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.Services.Contracts;
using MotorcycleMaintenance.ViewModels.Tax;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace MotorcycleMaintenance.Services
{
    public class TaxService : ITaxService
    {

        private readonly OdbcConnection con;
        private readonly OdbcCommand com;
        private readonly Logger.Logger logger;
        public TaxService()
        {
            con = new OdbcConnection(GlobalConstants.ConnectionsString);
            com = new OdbcCommand(" ",con);
            logger = new Logger.Logger();
        }

        public int GeTaxContCount(int taxId)
        {
            string query = $"select count(c.id) from contribution c ,  taxcontributions tc where c.id = tc.contribution_id and tc.tax_id = {taxId}";

            string contCountString = CommandExecuter.CommandExecuter.ExecuteString(query);

            return int.Parse(contCountString);
        }

        public LastTaxPayedViewModel GetLastTax(int motorcycleId)
        {
            LastTaxPayedViewModel lastTaxIdAndContCount = null;

            try
            {
                string query = $"select first 1 t.id ,t.contributioncount, t.payday, t.price from tax t where t.motorcycledata_id = {motorcycleId} order by t.payday desc";

                com.CommandText = query;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (var reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int taxId = int.Parse(reader["id"].ToString());
                        short contCount = short.Parse(reader["contributioncount"].ToString());
                        DateTime payDate = DateTime.Parse(reader["payday"].ToString());
                        double price = double.Parse(reader["price"].ToString());

                        lastTaxIdAndContCount = new LastTaxPayedViewModel
                        {
                            ContCount = contCount,
                            PayDate = payDate,
                            Price = price,
                            TaxId = taxId,
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogExceptionText(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return lastTaxIdAndContCount;
        }

        public int GetLastTaxId(int motorcycleId)
        {
            string selectQuery = $"select first 1 id from tax order by payday desc";

            string taxIdString = CommandExecuter.CommandExecuter.ExecuteString(selectQuery);

            return int.Parse(taxIdString);
        }

        public bool HasTax(int motorcycleId)
        {
            string selectQuery = $"select count(t.id) from tax t where t.motorcycledata_id = {motorcycleId}";

            string taxIdsCountString = CommandExecuter.CommandExecuter.ExecuteString(selectQuery);

            int taxIdsCount = int.Parse(taxIdsCountString);

            return taxIdsCount > 0;
        }
    }
}
