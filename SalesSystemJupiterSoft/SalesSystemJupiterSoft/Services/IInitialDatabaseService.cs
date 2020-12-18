namespace SalesSystemJupiterSoft.Services
{
    public interface IInitialDatabaseService
    {
        void CreateSalesIdTrigger();

        void SetValueToSalesGenerator();

        void CreateSalesGenerator();

        void CreateSalesTable();

        void CreateArticleIdTrigger();

        void SetValueToArticleGenerator();

        void CreateArticleIdGenerator();

        void CreateArticleTable();

        bool ChekIfTablesExist();
    }
}
