using MotorcycleMaintenance.InputModels.OilFilter;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IOilFilterService
    {
        void CreateOilFilter(OilFilterInputModel model);
    }
}
