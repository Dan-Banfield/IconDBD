using System;
using System.IO;
using Microsoft.Win32;

namespace IconDBD
{
    public static class IconPackManager
    {
        public static string SelectedIconPack { get; set; }

        private static string GetSteamPath(bool is64Bit)
        {
            string installPath = "";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(is64Bit ? @"SOFTWARE\Wow6432Node\Valve\Steam" : @"SOFTWARE\Valve\Steam"))
            {
                if (key != null)
                    installPath = (string)key.GetValue("InstallPath");
            }
            return installPath;
        }

        public static string GetDbDIconPath()
        {
            string steamInstallPath = GetSteamPath(Environment.Is64BitOperatingSystem);

            if (!string.IsNullOrEmpty(steamInstallPath))
            {
                string iconPath = Path.Combine(steamInstallPath, "steamapps", "common", "Dead by Daylight", "DeadByDaylight", "Content", "UI", "Icons");

                if (Directory.Exists(iconPath))
                    return iconPath;
            }
            return "";
        }
    }
}