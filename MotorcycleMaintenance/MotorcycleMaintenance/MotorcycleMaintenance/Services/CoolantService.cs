using MotorcycleMaintenance.CommandExecuter.Contracts;
using MotorcycleMaintenance.InputModels.Coolant;
using MotorcycleMaintenance.Services.Contracts;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class CoolantService : ICoolantService
    {
        private readonly ICommandExecuter commandExecuter;

        public CoolantService()
        {
            commandExecuter = new MotorcycleMaintenance.CommandExecuter.CommandExecuter();
        }

        public void CreateCoolant(CreateCoolantInputModel model)
        {
            StringBuilder insertIntoCoolandQuerySb = new StringBuilder();

            insertIntoCoolandQuerySb.Append($"execute procedure InsertIntoCoolant({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            commandExecuter.ExecuteNonQuery(insertIntoCoolandQuerySb.ToString());
        }
    }
}
