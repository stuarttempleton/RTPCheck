using Microsoft.Win32;


namespace RealTimeProtection;
internal class RTP
{
    public static bool Disabled()
    {
        bool disabled = true;
        string key = "DisableRealtimeMonitoring";
        string path = @"SOFTWARE\Microsoft\Windows Defender\Real-Time Protection";

        RegistryKey basekey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
        if (basekey != null)
        {
            var val = basekey.OpenSubKey(path).GetValue(key);
            disabled = val == null ? false : ((Int32)val != 0);
        }
        return disabled;
    }

    public static bool Enabled()
    {
        return !Disabled();
    }
}
