using MotorcycleMaintenance.InputModels.Tires;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface ITiresService
    {
        void CreateTires(CreateTiresInputModel model);
    }
}
