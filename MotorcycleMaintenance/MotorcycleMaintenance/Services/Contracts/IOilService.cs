using MotorcycleMaintenance.InputModels.Oil;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IOilService
    {
        void CreateOil(CreateOilInputModel model);
    }
}
