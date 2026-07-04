using System;
using System.Windows.Forms;
using NetworkMonitorPro.UI;

namespace NetworkMonitorPro
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
