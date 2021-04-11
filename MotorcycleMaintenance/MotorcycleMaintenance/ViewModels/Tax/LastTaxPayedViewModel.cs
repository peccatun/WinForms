using System;

namespace MotorcycleMaintenance.ViewModels.Tax
{
    public class LastTaxPayedViewModel
    {
        public int TaxId { get; set; }

        public short ContCount { get; set; }

        public DateTime PayDate{ get; set; }

        public double Price { get; set; }
    }
}
