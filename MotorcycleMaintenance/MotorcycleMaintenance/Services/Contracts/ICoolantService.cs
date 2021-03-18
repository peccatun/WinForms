using MotorcycleMaintenance.InputModels.Coolant;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface ICoolantService
    {
        void CreateCoolant(CreateCoolantInputModel model);
    }
}
