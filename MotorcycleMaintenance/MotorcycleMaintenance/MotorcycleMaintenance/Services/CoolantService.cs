using MotorcycleMaintenance.InputModels.Coolant;
using MotorcycleMaintenance.Services.Contracts;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class CoolantService : ICoolantService
    {
        public CoolantService()
        {

        }

        public void CreateCoolant(CreateCoolantInputModel model)
        {
            StringBuilder insertIntoCoolandQuerySb = new StringBuilder();

            insertIntoCoolandQuerySb.Append($"execute procedure InsertIntoCoolant({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertIntoCoolandQuerySb.ToString());
        }
    }
}
