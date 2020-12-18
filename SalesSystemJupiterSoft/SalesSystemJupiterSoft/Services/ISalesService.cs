using SalesSystemJupiterSoft.ViewModels.Sales;
using System;
using System.Collections.Generic;

namespace SalesSystemJupiterSoft.Services
{
    public interface ISalesService
    {
        void MakeSale(int articleId, int quantity);

        IEnumerable<DisplaySalesDetailsViewModel> GetSalesForDGV();

        IEnumerable<DisplaySalesDetailsViewModel> GetSalesReference(DateTime fromDate, DateTime toDate);
    }
}
