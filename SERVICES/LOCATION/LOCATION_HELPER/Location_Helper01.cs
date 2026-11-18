using System;
using System.Diagnostics.Contracts;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.DEVICES.DEVICE_SERVICES;


namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER
{
    public class Location_Helper01
    {
        private static string[] data01 = new string[100];
        private static Device_Services01 Device_S01 = new Device_Services01();
        public static string res_string { get; set; }
        public static bool res_bool = false;

        private static async Task load_helper01()
        {
            var res = await Device_S01.get_device_ip();
            
            if (res.success == true)
            {
                res_bool = res.success;
                res_string = res.output;
            }
            else
            {
                res_bool = res.success;
                res_string = res.output;
            }
        }
        public Location_Helper01()
        {
            load_helper01().Wait();
        }

    }
}