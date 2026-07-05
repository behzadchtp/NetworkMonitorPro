namespace NetworkMonitorPro.Core
{
    public static class UnitFormatter
    {
        public static string FormatBitsPerSecond(double bps)
        {
            string[] units = { "bps", "Kbps", "Mbps", "Gbps", "Tbps" };

            int index = 0;

            while (bps >= 1000 && index < units.Length - 1)
            {
                bps /= 1000;
                index++;
            }

            return $"{bps:0.##} {units[index]}";
        }
    }
}
