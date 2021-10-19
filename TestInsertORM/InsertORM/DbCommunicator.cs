using InsertORM.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace InsertORM
{
    public class DbCommunicator : IDbCommunicator
    {
        private readonly string conString;

        private readonly InsertStatementGenerator isn;
        private readonly List<string> insertStatementList;

        public DbCommunicator(string conString)
        {
            isn = new InsertStatementGenerator();
            insertStatementList = new List<string>();

            this.conString = conString;
        }

        public void Add<T>(T inputModel)
        {
            try
            {
                string insertStatement = isn.InsertTableRow(inputModel);

                insertStatementList.Add(insertStatement);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CommitTransaction()
        {
            if (insertStatementList.Count < 1)
            {
                throw new ArgumentException("Няма единица за добавяне");
            }

            using (OdbcConnection con = new OdbcConnection(conString))
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                OdbcTransaction transaction = con.BeginTransaction();

                try
                {
                    foreach (string insertStatement in insertStatementList)
                    {

                        using (OdbcCommand com = new OdbcCommand(insertStatement, con, transaction))
                        {
                            com.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    throw ex;
                }

                transaction.Commit();

            }
        }
    }
}
