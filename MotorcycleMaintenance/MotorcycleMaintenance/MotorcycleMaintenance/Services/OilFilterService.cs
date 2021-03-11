using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.OilFilter;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class OilFilterService : IOilFilterService
    {
        public OilFilterService()
        {

        }

        public void CreateOilFilter(OilFilterInputModel model)
        {

            StringBuilder insertIntoOilFilterQuery = new StringBuilder();

            insertIntoOilFilterQuery.Append($"execute procedure InsertIntoOilFilter({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertIntoOilFilterQuery.ToString());
        }
    }
}
