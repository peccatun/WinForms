using MotorcycleMaintenance.InputModels.BrakeFluid;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IBrakeFluidService
    {
        void CreateBrakeFluid(CreateBrakeFluidInputModel model);
    }
}
