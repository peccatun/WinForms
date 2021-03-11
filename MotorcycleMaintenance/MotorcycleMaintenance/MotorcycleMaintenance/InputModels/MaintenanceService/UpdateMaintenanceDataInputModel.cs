namespace MotorcycleMaintenance.InputModels.MaintenanceService
{
    public class UpdateMaintenanceDataInputModel
    {
        public string TableName { get; set; }

        public int KilometersDriven { get; set; }

        public int MonthsDriven { get; set; }

        public int MotorcycleId { get; set; }
    }
}
