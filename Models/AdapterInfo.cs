namespace NetworkMonitorPro.Models
{
    public class AdapterInfo
    {
        public string Name { get; set; } = string.Empty;

        public string IPv4 { get; set; } = string.Empty;

        public string IPv6 { get; set; } = string.Empty;

        public string MacAddress { get; set; } = string.Empty;

        public string InterfaceType { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public long LinkSpeed { get; set; }

        public double ReceiveSpeed { get; set; }

        public double SendSpeed { get; set; }

        public double Throughput => ReceiveSpeed + SendSpeed;
    }
}
