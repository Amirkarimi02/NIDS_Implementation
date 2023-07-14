using System;
using System.IO;

namespace NIDS_Implementation.Classes
{
    public class Logger
    {
        private string logFilePath;

        public Logger(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public void LogIntrusionAlert(IntrusionAlert intrusionAlert)
        {
            string logMessage = $"[Intrusion Alert] {intrusionAlert.Timestamp}: {intrusionAlert.RuleTriggered} - {intrusionAlert.SeverityLevel}";

            // Write the log message to the log file
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logMessage);
            }

            Console.WriteLine("Intrusion alert logged successfully.");
        }
    }
}
