using System;

namespace SalesSystemJupiterSoft.ViewModels.Sales
{
    public class DisplaySalesDetailsViewModel
    {
        public string SoldItemName { get; set; }

        public int SoldQuantity { get; set; }

        public decimal SoldItemPrice { get; set; }

        public decimal SoldItemSumPrice { get; set; }

        public DateTime SoldDate { get; set; }
    }
}
