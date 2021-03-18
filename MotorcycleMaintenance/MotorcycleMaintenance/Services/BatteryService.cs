using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.Battery;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class BatteryService : IBatteryService
    {

        public BatteryService()
        {

        }


        /// <summary>
        /// Create new oil
        /// </summary>
        /// <param name="model"></param>
        public void CreateBattery(CreateBatteryInputModel model)
        {
            StringBuilder createBatteryQuery = new StringBuilder();

            createBatteryQuery.Append($"execute procedure insertintobattry({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            CommandExecuter.CommandExecuter.ExecuteNonQuery(createBatteryQuery.ToString());

        }
    }
}
