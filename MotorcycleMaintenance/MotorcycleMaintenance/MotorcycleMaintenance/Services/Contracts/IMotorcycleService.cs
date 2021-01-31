using MotorcycleMaintenance.InputModels;
using MotorcycleMaintenance.ViewModels;
using System.Collections.Generic;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IMotorcycleService
    {
        void EnterMotorcycleInfo(MotorcycleInfoInputModel model);

        void SetMotorcycleDataVariables(UserMotorcycleViewModel model);

        List<UserMotorcycleViewModel> GetUserMotorcycles(int userId);

        UserMotorcycleViewModel GetMotorcycleForMainForm(int motorcycleId);

        bool HasMotorcycles(int userId);

        bool HasMotorcycle(int motorcycleId);
    }
}
