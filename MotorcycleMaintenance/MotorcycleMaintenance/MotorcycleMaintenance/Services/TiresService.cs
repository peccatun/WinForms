using MotorcycleMaintenance.CommandExecuter.Contracts;
using MotorcycleMaintenance.InputModels.Tires;
using MotorcycleMaintenance.Services.Contracts;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class TiresService : ITiresService
    {
        private readonly ICommandExecuter commandExecuter;

        public TiresService()
        {
            commandExecuter = new MotorcycleMaintenance.CommandExecuter.CommandExecuter();
        }

        public void CreateTires(CreateTiresInputModel model)
        {
            StringBuilder insertIntoTiresQuery = new StringBuilder();

            insertIntoTiresQuery.Append($"execute procedure InsertIntoTires({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            commandExecuter.ExecuteNonQuery(insertIntoTiresQuery.ToString());
        }
    }
}
