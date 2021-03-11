using MotorcycleMaintenance.InputModels.Tires;
using MotorcycleMaintenance.Services.Contracts;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class TiresService : ITiresService
    {
        public TiresService()
        {

        }

        public void CreateTires(CreateTiresInputModel model)
        {
            StringBuilder insertIntoTiresQuery = new StringBuilder();

            insertIntoTiresQuery.Append($"execute procedure InsertIntoTires({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertIntoTiresQuery.ToString());
        }
    }
}
