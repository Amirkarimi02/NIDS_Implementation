# Network Intrusion Detection System (NIDS)

## Overview
The Network Intrusion Detection System (NIDS) is a console application that monitors network traffic and detects potential intrusion attempts based on predefined rules. It analyzes network packets and raises intrusion alerts when suspicious patterns or signatures are detected.

## Features
- Packet capture: Captures network packets in real-time using the Pcap.Net library.
- Rule-based detection: Applies a set of predefined rules to analyze network packets and identify potential intrusion attempts.
- Intrusion alert logging: Logs intrusion alerts to a specified log file using a customizable log format.
- Network packet information: Extracts relevant information from network packets, such as source and destination IP addresses, ports, and protocols.
- Customizable rules: Allows users to define their own intrusion detection rules to suit specific requirements.

## Prerequisites
Before running the application, ensure the following prerequisites are met:
- Built in Release mode: Make sure the application is built in Release mode for optimal performance.
- WinPcap: Install WinPcap 4.1.3, available at http://www.winpcap.org, as it is required by the Pcap.Net library.
- .NET Framework 4.5: Install .NET Framework 4.5 or a later version from the Microsoft Download Center.
- Microsoft Visual C++ Redistributable Packages: Install both the Microsoft Visual C++ 2010 Redistributable Package and the Microsoft Visual C++ 2013 Redistributable Package to fulfill the necessary runtime components.

## Installation
1. Clone the repository or download the source code.
2. Build the project in Release mode.

## Usage
1. Install the required dependencies as mentioned in the prerequisites section.
2. Run the NIDS application from the command line or terminal.
3. Configure the application by providing the necessary parameters, such as rule set file path and log file path.
4. Start capturing network packets and monitoring for intrusion attempts.
5. View intrusion alerts in the console and log file.

## Customization
The NIDS application can be customized according to specific requirements:
- Rule set: Modify the rule set file to define custom intrusion detection rules.
- Logging: Customize the log file format and destination.
- Network packet analysis: Extend the network packet analysis functionality to extract additional information or implement new detection techniques.

## Resources
- [Pcap.Net](https://github.com/PcapDotNet/Pcap.Net): Official repository for the Pcap.Net library, which is used for packet capturing in the NIDS application.
- [Using Pcap.Net in Your Programs](https://github.com/PcapDotNet/Pcap.Net/wiki/Using-Pcap.Net-in-your-programs): Detailed guide on using Pcap.Net library in your own programs, providing helpful information and code examples.

## License
This project is licensed under the [MIT License](LICENSE).

## Contact
For any inquiries or feedback, please contact Amir Karimi at karimika13.ka@gmail.com.
