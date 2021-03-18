using MotorcycleMaintenance.InputModels.MaintenanceService;
using System;
using System.Windows.Forms;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IMaintenanceService
    {
        void SetMaintenance(ComboBox comboBox);

        void FillDataGridInformation(string maintenanceType, ref DataGridView dataGrid);

        bool IsNotLast(string tableName, int motorcycleId);

        int CalculateMonthsDriven(DateTime currentMothsDriven, DateTime lastMonthsDriven);

        int CalculateKilometersDriven(int currentKilometersDriven, int lastKilometersDriven);

        CalculationDataModel GetCalculationDataModel(string tableName, int motorcycleId);

        void SetAdditionalData(UpdateMaintenanceDataInputModel model);
    }
}
