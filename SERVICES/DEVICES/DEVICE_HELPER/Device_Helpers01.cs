
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Management;
using System;
using System.IO;
namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.DEVICES.DEVICE_HELPER
{
    public class Device_Helpers01
    {
        private static string[] data01 = new string[100];
        public string OS_String = string.Empty;

        private static ManagementObjectSearcher[] searcher =
              {
            new ManagementObjectSearcher("SELECT Manufacturer, Model FROM Win32_ComputerSystem"),
           new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS")
        };
        private bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        private bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        private bool isMac = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        private bool isAndroid = RuntimeInformation.OSDescription.Contains("Android", StringComparison.OrdinalIgnoreCase);
        private bool isIOS = RuntimeInformation.IsOSPlatform(OSPlatform.Create("IOS"));
        private string GetLinux_manufacturer = File.ReadAllText("/sys/class/dmi/id/sys_vendor");
        private string GetLinux_model = File.ReadAllText("/sys/class/dmi/id/product_name");
        private string GetLinux_serial = File.ReadAllText("/etc/machine-id");
        public string GetEnvironmentVariables_string = string.Empty;
        public string windows_info01 = string.Empty;

        public Device_Helpers01()
        {

            OS_String = $"Windows:{isWindows}\n" +
                        $"linux:{isLinux}\n" +
                        $"macOS:{isMac}\n" +
                        $"android:{isAndroid}\n" +
                        $"iOS:{isIOS}\n";


            foreach (System.Collections.DictionaryEntry env in Environment.GetEnvironmentVariables())
            {
                GetEnvironmentVariables_string += $"Key: {env.Key}\n" +
                                                  $"Value {env.Value}\n";
            }

            load_Windows_details();

        }
        private void load_Windows_details()
        {
            if (isWindows == true)
            {
                foreach (ManagementObject obj in searcher[0].Get())
                {
                    windows_info01 += $"Manufacturer: {obj["Manufacturer"]}\n" +
                                 $"Model: {obj["Model"]}";
                }

                foreach (ManagementObject obj in searcher[1].Get())
                {
                    windows_info01 += $"Serial: {obj["SerialNumber"]}";
                }

            }
            else
            {
                windows_info01 = "not supported";

            }
        }
        public string load_device_details01()
        {
            return
$"MachineName:{Environment.MachineName}\n" +
$"UserName:{Environment.UserName}\n" +
$"UserDomainName:{Environment.UserDomainName}\n" +
$"OSVersion:{Environment.OSVersion}\n" +
$"Is64BitOperatingSystem:{Environment.Is64BitOperatingSystem}\n" +
$"Is64BitProcess:{Environment.Is64BitProcess}\n" +
$"ProcessorCount:{Environment.ProcessorCount}\n" +
$"SystemDirectory:{Environment.SystemDirectory}\n" +
$"CurrentDirectory:{Environment.CurrentDirectory}\n" +
$"CommandLine: {Environment.CommandLine}\n" +
$"ProcessId:{Environment.ProcessId}\n" +
$"TickCount64: {Environment.TickCount64}\n" +
$"Version:{Environment.Version}\n" +
$"USERNAME:{Environment.GetEnvironmentVariable("USERNAME")}\n" +
$"COMPUTERNAME:{Environment.GetEnvironmentVariable("COMPUTERNAME")}\n" +
$"TEMP:{Environment.GetEnvironmentVariable("TEMP")}\n" +
$"PATH:{Environment.GetEnvironmentVariable("PATH")}\n" +
$"SpecialFolder_Desktop:{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\n" +
$"SpecialFolder_MyDocuments:{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\n" +
$"SpecialFolder_ApplicationData:{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\n" +
$"SpecialFolder_LocalApplicationData:{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\n" +
$"SpecialFolder_ProgramFiles:{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\n" +
$"SpecialFolder_Windows:{Environment.GetFolderPath(Environment.SpecialFolder.Windows)}\n" +
$"OSDescription:{RuntimeInformation.OSDescription}\n" +
$"FrameworkDescription:{RuntimeInformation.FrameworkDescription}\n" +
$"OSArchitecture:{RuntimeInformation.OSArchitecture}\n" +
$"ProcessArchitecture:{RuntimeInformation.ProcessArchitecture}\n" +
$"Now:{DateTime.Now}\n" +
$"UtcNow:{DateTime.UtcNow}\n" +
$"DisplayName:{TimeZoneInfo.Local.DisplayName}\n" +
$"GetTotalMemory: {GC.GetTotalMemory(false)}\n";


        }
        public string GetLinuxDetails()
        {
            return
                $"Manufacturer: {GetLinux_manufacturer}\n" +
                $"Model: {GetLinux_model}\n" +
                $"Serial: {GetLinux_serial}";
        }
    }
}