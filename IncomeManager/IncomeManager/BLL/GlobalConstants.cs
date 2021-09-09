using System.IO;
using System.Reflection;

namespace BLL
{
    public static class GlobalConstants
    {
        private const string ConfFolderName = "\\conf";
        private const string ConnectionStringFile = "\\conStr.txt";


        public static string ConfFolderPath 
        {
            get 
            {
                string currentAssemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string confFolderPath = currentAssemblyPath + ConfFolderName;
                return confFolderPath;

            }
        }

        public static string ConnectionString 
        {
            get 
            {
                string conStrFilePath = ConfFolderPath + ConnectionStringFile;
                string connectionString = File.ReadAllText(conStrFilePath);
                return connectionString;
            }
        }
    }
}
