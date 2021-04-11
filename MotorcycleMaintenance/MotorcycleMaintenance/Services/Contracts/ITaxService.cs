using MotorcycleMaintenance.ViewModels.Tax;
using System.Collections.Generic;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface ITaxService
    {
        bool HasTax(int motorcycleId);

        LastTaxPayedViewModel GetLastTax(int motorcycleId);

        int GeTaxContCount(int taxId);

        int GetLastTaxId(int motorcycleId);
    }
}
