using MotorcycleMaintenance.CommandExecuter.Contracts;
using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.Oil;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class OilService : IOilService
    {
        private readonly ICommandExecuter commandExecuter;

        public OilService()
        {
            commandExecuter = new CommandExecuter.CommandExecuter();
        }

        /// <summary>
        /// Creates new oil 
        /// </summary>
        /// <param name="model"></param>
        public void CreateOil(CreateOilInputModel model)
        {
            StringBuilder insertIntoOilQuery = new StringBuilder();

            insertIntoOilQuery.Append($"execute procedure InsertIntoOil({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            commandExecuter.ExecuteNonQuery(insertIntoOilQuery.ToString());
        }
    }
}
