using MotorcycleMaintenance.InputModels.Clutch;
using MotorcycleMaintenance.Services.Contracts;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class ClutchService : IClutchService
    {

        public ClutchService()
        {

        }

        public void CreateClutch(CreateClutchInputModel model)
        {
            StringBuilder insertIntoClutchQuery = new StringBuilder();

            insertIntoClutchQuery.Append($"execute procedure InsertIntoClutch({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertIntoClutchQuery.ToString());
        }
    }
}
