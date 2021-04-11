using MotorcycleMaintenance.Globals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcycleMaintenance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            SetDbPath();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        static void SetDbPath()
        {
            string dbPath = string.Empty;

            using (StreamReader sw = new StreamReader(GlobalConstants.DbPath.DbPathFilePath))
            {
                while ((dbPath = sw.ReadLine()) != null)
                {
                    GlobalConstants.ConnectionsString += dbPath;
                }
            }
        }
    }
}
