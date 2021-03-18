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

        public BrakeFluidService()
        {

        }

        public void CreateBrakeFluid(CreateBrakeFluidInputModel model)
        {

                StringBuilder insertIntoBrakeFluidQuerySb = new StringBuilder();

                insertIntoBrakeFluidQuerySb.Append($"execute procedure InsertIntoBrakeFLuid({model.Price},'{model.Make}','{model.ChangeDate}',{model.MotorcycleId},{model.KilometersOnChange});");

            CommandExecuter.CommandExecuter.ExecuteNonQuery(insertIntoBrakeFluidQuerySb.ToString());
        }
    }
}
