using MotorcycleMaintenance.CommandExecuter.Contracts;
using MotorcycleMaintenance.Globals;
using MotorcycleMaintenance.InputModels.BrakeFluid;
using MotorcycleMaintenance.Services.Contracts;
using System;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace MotorcycleMaintenance.Services
{
    public class BrakeFluidService : IBrakeFluidService
    {
        private readonly ICommandExecuter commandExecuter;

        public BrakeFluidService()
        {
            commandExecuter = new CommandExecuter.CommandExecuter();
        }

        public void CreateBrakeFluid(CreateBrakeFluidInputModel model)
        {

                StringBuilder insertIntoBrakeFluidQuerySb = new StringBuilder();

                insertIntoBrakeFluidQuerySb.Append($"execute procedure InsertIntoBrakeFLuid({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            commandExecuter.ExecuteNonQuery(insertIntoBrakeFluidQuerySb.ToString());
        }
    }
}
