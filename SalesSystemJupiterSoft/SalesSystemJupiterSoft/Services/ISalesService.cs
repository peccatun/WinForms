using SalesSystemJupiterSoft.ViewModels.Sales;
using System.Collections.Generic;

namespace SalesSystemJupiterSoft.Services
{
    public interface ISalesService
    {
        void MakeSale(int articleId, int quantity);

        IEnumerable<DisplaySalesDetailsViewModel> GetSalesForDGV();
    }
}
