using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.FrontBrakes;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class FrontBrakesService : IFrontBrakesService
    {
        public FrontBrakesService()
        {

        }

        public void CreateFrontBrakes(FrontBrakesInputModel model)
        {

            StringBuilder insertIntoFrontBrakesQuery = new StringBuilder();

            insertIntoFrontBrakesQuery
                .Append($"execute procedure InsertIntoFrontBrakes({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertIntoFrontBrakesQuery.ToString());
        }
    }
}
