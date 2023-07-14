using System;
using System.Collections.Generic;
using NIDS_Implementation.Classes;

namespace NIDS_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the rule set for intrusion detection
            List<string> ruleSet = new List<string>
            {
                "Keyword1",
                "Keyword2",
                "Keyword3"
            };

            // Define the log file path
            string logFilePath = "intrusion_log.txt";

            // Create an instance of the IntrusionDetectionEngine
            IntrusionDetectionEngine detectionEngine = new IntrusionDetectionEngine(ruleSet, logFilePath);

            // Start capturing network packets
            detectionEngine.StartCapture();

            Console.WriteLine("Intrusion Detection System running. Press any key to stop...");

            // Wait for a key press to stop capturing packets
            Console.ReadKey();

            // Stop capturing network packets
            detectionEngine.StopCapture();

            // Get the intrusion alerts
            List<IntrusionAlert> alerts = detectionEngine.GetIntrusionAlerts();

            Console.WriteLine("Intrusion Alerts:");

            // Display the intrusion alerts
            foreach (var alert in alerts)
            {
                Console.WriteLine($"Timestamp: {alert.Timestamp}");
                Console.WriteLine($"Rule Triggered: {alert.RuleTriggered}");
                Console.WriteLine($"Severity Level: {alert.SeverityLevel}");
                Console.WriteLine($"Recommended Response Actions: {alert.RecommendedResponseActions}");
                Console.WriteLine($"Network Flow Information: {alert.NetworkFlowInformation}");
                Console.WriteLine($"Source IP Address: {alert.SourceIPAddress}");
                Console.WriteLine($"Destination IP Address: {alert.DestinationIPAddress}");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
