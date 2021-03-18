using MotorcycleMaintenance.InputModels.RearBrakes;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IRearBrakesService
    {
        void CreateRearBrakes(CreateRearBrakesInputModel model);
    }
}
