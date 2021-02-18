using MotorcycleMaintenance.CommandExecuter.Contracts;
using MotorcycleMaintenance.InputModels.Clutch;
using MotorcycleMaintenance.Services.Contracts;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class ClutchService : IClutchService
    {
        private readonly  ICommandExecuter commandExecuter;

        public ClutchService()
        {
            commandExecuter = new CommandExecuter.CommandExecuter();
        }

        public void CreateClutch(CreateClutchInputModel model)
        {
            StringBuilder insertIntoClutchQuery = new StringBuilder();

            insertIntoClutchQuery.Append($"execute procedure InsertIntoClutch({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            commandExecuter.ExecuteNonQuery(insertIntoClutchQuery.ToString());
        }
    }
}
