using System;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

namespace IconDBD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string GetDBDIconPath()
        {
            string steamInstallPath = GetSteamInstallPath(Environment.Is64BitOperatingSystem);

            if (!string.IsNullOrEmpty(steamInstallPath))
            {
                string iconPath = Path.Combine(steamInstallPath, "steamapps", "common", "Dead by Daylight", "DeadByDaylight", "Content", "UI", "Icons");

                if (Directory.Exists(iconPath))
                    return iconPath;
            }
            return "";
        }

        private string GetSteamInstallPath(bool is64Bit)
        {
            string installPath = "";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(is64Bit ? @"SOFTWARE\Wow6432Node\Valve\Steam" : @"SOFTWARE\Valve\Steam"))
            {
                if (key != null)
                    installPath = (string)key.GetValue("InstallPath");
            }
            return installPath;
        }
    }
}