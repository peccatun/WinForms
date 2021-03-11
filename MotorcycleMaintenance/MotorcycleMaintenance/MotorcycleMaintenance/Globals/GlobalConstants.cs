using System.Text;

namespace MotorcycleMaintenance.Globals
{
    public static class GlobalConstants
    {
        //public const string ConnectionsString = "DSN=MotorcycleMaintenance;Server=localhost;User=SYSDBA;Password=masterkey;Database=D:\\C#Experiments\\MotorcycleMaintenance\\MOTORCYCLEMAINTENANCEDB.FDB";

        public const string ConnectionsString = @"DSN=MotorcycleMaintenance;Server=127.0.0.1;User=SYSDBA;Password=masterkey;Database=C:\Users\Petko\Desktop\MOTORCYCLEMAINTENANCEDB.FDB";


        public const string MessageBoxTopInfo = "Motorcycle Mantenance";

        public static class MantainanceType
        {
            public static string Battery = "Battery";

            public static string Brakefluid = "Brakefluid";

            public static string Clutch = "Clutch";

            public static string Coolant = "Coolant";

            public static string FrontBrakes = "FrontBrake";

            public static string Oil = "Oil";

            public static string RearBrake = "RearBrakes";

            public static string Tires = "Tires";

            public static string OilFilter = "OilFilter";
        }
    }
}
