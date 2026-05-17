using System;
using System.Threading.Tasks;
using EASY_CALLENDER01.SERVICES.DEVICE_SERVICES;

namespace EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER
{
    public class Location_Helper01
    {
        private static Device_Services01 Device_S01 = new Device_Services01();
        public static string get_ipaddress01 { get; set; }
        public static string get_city01 { get; set; }
        public static string get_state01 { get; set; }
        public static string get_country01 { get; set; }
        public static string get_location_grid01 { get; set; }
        public static string get_longitude { get; set; }
        public static string get_latitude { get; set; }

        private async Task InitializeAsync()
        {
            string raw_data = await Device_S01.get_device_ip();
            var lines = raw_data.Split('\n');
            get_ipaddress01 = lines[0].Trim();
            get_city01 = lines[1].Trim();
            get_state01 = lines[2].Trim();
            get_country01 = lines[3].Trim();
            get_location_grid01 = lines[4].Trim();
            var coords = get_location_grid01.Split(',');
            get_longitude = coords[0].Trim();
            get_latitude = coords[1].Trim();

        }
        private void load_async()
        {
            InitializeAsync().Wait();
        }

        public Location_Helper01()
        {
            load_async();
        }


    }
}