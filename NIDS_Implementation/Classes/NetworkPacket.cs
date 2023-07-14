using System;
using System.Net;

namespace NIDS_Implementation.Classes
{
    public class NetworkPacket
    {
        public DateTime Timestamp { get; private set; }
        public string SourceIPAddress { get; private set; }
        public string DestinationIPAddress { get; private set; }
        public string Protocol { get; private set; }
        public byte[] Data { get; set; }
        public string NetworkFlowInformation => $"{SourceIPAddress} -> {DestinationIPAddress}";

        public NetworkPacket(DateTime timestamp, string sourceIPAddress, string destinationIPAddress, string protocol, byte[] data)
        {
            Timestamp = timestamp;
            SourceIPAddress = sourceIPAddress;
            DestinationIPAddress = destinationIPAddress;
            Protocol = protocol;
            Data = data;
        }
    }
}
