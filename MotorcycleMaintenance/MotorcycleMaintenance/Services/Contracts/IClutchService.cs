using MotorcycleMaintenance.InputModels.Clutch;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IClutchService
    {
        void CreateClutch(CreateClutchInputModel model);
    }
}
