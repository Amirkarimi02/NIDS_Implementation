using System;

namespace NIDS_Implementation.Classes
{
    public class IntrusionAlert
    {
        public DateTime Timestamp { get; private set; }
        public string RuleTriggered { get; private set; }
        public string SeverityLevel { get; private set; }
        public string RecommendedResponseActions { get; private set; }
        public string NetworkFlowInformation { get; private set; }
        public string SourceIPAddress { get; private set; }
        public string DestinationIPAddress { get; private set; }

        public IntrusionAlert(DateTime timestamp, string ruleTriggered, string severityLevel, string recommendedResponseActions, string networkFlowInformation, string sourceIPAddress, string destinationIPAddress)
        {
            Timestamp = timestamp;
            RuleTriggered = ruleTriggered;
            SeverityLevel = severityLevel;
            RecommendedResponseActions = recommendedResponseActions;
            NetworkFlowInformation = networkFlowInformation;
            SourceIPAddress = sourceIPAddress;
            DestinationIPAddress = destinationIPAddress;
        }
    }
}
