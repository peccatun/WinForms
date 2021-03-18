using MotorcycleMaintenance.InputModels.FrontBrakes;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IFrontBrakesService
    {
        void CreateFrontBrakes(FrontBrakesInputModel model);
    }
}
