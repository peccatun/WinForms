using MotorcycleMaintenance.InputModels.Battery;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IBatteryService
    {
        void CreateBattery(CreateBatteryInputModel model);
    }
}
