using System.IO;
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

            public static string FrontBrakes = "FrontBrakes";

            public static string Oil = "Oil";

            public static string RearBrake = "RearBrake";

            public static string Tires = "Tires";

            public static string OilFilter = "OilFilter";
        }

        public static class Logger
        {
            public static string LogFolderName = "Log";

            public static string LogFolderPath = $@"{Directory.GetCurrentDirectory()}\{LogFolderName}";

            public static class Exception
            {
                public static string LogFileName = "ExceptionLogFile.txt";

                public static string LogFilePath = $@"{LogFolderPath}\{LogFileName}";
            }
        }
    }
}
