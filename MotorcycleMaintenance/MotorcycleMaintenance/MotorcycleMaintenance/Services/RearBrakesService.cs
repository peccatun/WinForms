using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.RearBrakes;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class RearBrakesService : IRearBrakesService
    {
        public RearBrakesService()
        {

        }

        public void CreateRearBrakes(CreateRearBrakesInputModel model)
        {

            StringBuilder insertIntoRearBrakesQuerySb = new StringBuilder();

            insertIntoRearBrakesQuerySb.Append($"execute procedure InsertIntoRearBrakes({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertIntoRearBrakesQuerySb.ToString());

        }
    }
}
