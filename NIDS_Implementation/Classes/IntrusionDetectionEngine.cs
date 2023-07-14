using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using PcapDotNet.Core;
using PcapDotNet.Packets;

namespace NIDS_Implementation.Classes
{
    public class IntrusionDetectionEngine
    {
        private List<string> ruleSet;
        private Logger logger;
        private List<IntrusionAlert> intrusionAlerts;
        private PacketDevice selectedDevice;

        public IntrusionDetectionEngine(List<string> ruleSet, string logFilePath)
        {
            this.ruleSet = ruleSet;
            logger = new Logger(logFilePath);
            intrusionAlerts = new List<IntrusionAlert>();
        }

        public void StartCapture()
        {
            selectedDevice = GetDefaultDevice();

            if (selectedDevice != null)
            {
                using (PacketCommunicator communicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
                {
                    communicator.ReceivePackets(0, PacketHandler);
                }
            }
            else
            {
                Console.WriteLine("No network device found.");
            }
        }

        public void StopCapture()
        {
            selectedDevice = null;
            Console.WriteLine("Packet capture stopped.");
        }

        public List<IntrusionAlert> GetIntrusionAlerts()
        {
            return intrusionAlerts;
        }

        private void PacketHandler(Packet packet)
        {
            var ipPacket = packet.Ethernet.IpV4;
            if (ipPacket != null)
            {
                var networkPacket = new NetworkPacket(
                    DateTime.Now,
                    ipPacket.Source.ToString(),
                    ipPacket.Destination.ToString(),
                    ipPacket.Protocol.ToString(),
                    ipPacket.Payload.ToArray());

                ProcessPacket(networkPacket);
            }
        }

        private void ProcessPacket(NetworkPacket packet)
        {
            if (IsPacketSuspicious(packet))
            {
                var alert = new IntrusionAlert(DateTime.Now, "RuleTriggered", "SeverityLevel", "RecommendedResponseActions", packet.NetworkFlowInformation, packet.SourceIPAddress, packet.DestinationIPAddress);
                intrusionAlerts.Add(alert);
                logger.LogIntrusionAlert(alert);
                Console.WriteLine("Intrusion detected! Alert logged.");
            }
        }

        private bool IsPacketSuspicious(NetworkPacket packet)
        {
            string packetData = Encoding.ASCII.GetString(packet.Data);
            return ruleSet.Exists(rule => packetData.Contains(rule));
        }

        private static PacketDevice GetDefaultDevice()
        {
            var devices = LivePacketDevice.AllLocalMachine;
            if (devices.Count == 0)
                return null;

            return devices[0];
        }
    }
}
