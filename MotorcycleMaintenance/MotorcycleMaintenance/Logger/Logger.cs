using MotorcycleMaintenance.Globals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MotorcycleMaintenance.Logger
{
    public class Logger
    {
        public void LogExceptionText(string exeptionText, string text = " ")
        {
            CreateLogFolder();
            CreateExeptionLogFile();
            WriteInExeptionFile(exeptionText, text);

        }

        private void WriteInExeptionFile(string exeptionText, string text)
        {
            StringBuilder generateExeptionTextSb = new StringBuilder();

            List<string> lines = new List<string>();

            lines.Add("------------------------------");
            lines.Add("Exception: ");
            lines.Add(exeptionText);
            lines.Add("Моето съобщение ");
            lines.Add(text);
            lines.Add("Exception throw date and time:");
            lines.Add(DateTime.Now.ToString());
            lines.Add("------------------------------");

            using (StreamWriter sw = new StreamWriter(GlobalConstants.Logger.Exception.LogFilePath, true))
            {
                foreach (var line in lines)
                {
                    sw.WriteLine(line);
                }
            }

        }

        public void LogWarrningText(string text)
        {

        }

        public void LogUserActivity(string text)
        {

        }

        private void CreateLogFolder()
        {
            if (!Directory.Exists(GlobalConstants.Logger.LogFolderPath))
            {
                Directory.CreateDirectory(GlobalConstants.Logger.LogFolderPath);
            }
        }

        private void CreateExeptionLogFile()
        {
            if (!File.Exists(GlobalConstants.Logger.Exception.LogFilePath))
            {
                using (var file = File.Create(GlobalConstants.Logger.Exception.LogFilePath))
                {

                }

            }
        }
    }
}
