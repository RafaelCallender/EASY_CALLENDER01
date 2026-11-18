using System.Text;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_MANAGER
{
    public class Location_Manager01
    {

        private static Location_Helper01 Location_H01 = new Location_Helper01();
        private static string[] data01 = new string[100];
        public static string get_ipaddress01 { get; set; } = string.Empty;
        public static string get_city01 { get; set; } = string.Empty;
        public static string get_state01 { get; set; } = string.Empty;
        public static string get_country01 { get; set; } = string.Empty;
        public static string get_location_grid01 { get; set; } = string.Empty;
        public static string get_longitude { get; set; } = string.Empty;
        public static string get_latitude { get; set; } = string.Empty;
        public static string raw_data { get; set; } = string.Empty;
        public static string get_city_mobile01 { get; set; } = string.Empty;
        public static string get_state_mobile01 { get; set; } = string.Empty;
        public static string get_country_mobile01 { get; set; } = string.Empty;
        public static string get_longitude_mobile { get; set; } = string.Empty;
        public static string get_latitude_mobile { get; set; } = string.Empty;
        public static string status_string { get; set; } = string.Empty;


        public Location_Manager01()
        {

            set_mobible_location().Wait();
        }



        private void load_location()
        {
            if (Location_Helper01.res_bool == true)
            {
                raw_data = Location_Helper01.res_string;
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
            else
            {
                raw_data = Location_Helper01.res_string;
                get_ipaddress01 = string.Empty;
                get_city01 = string.Empty;
                get_state01 = string.Empty;
                get_country01 = string.Empty;
                get_location_grid01 = string.Empty;
                get_longitude = string.Empty;
                get_latitude = string.Empty;
            }

        }

        private async Task set_mobible_location()
        {
            var res = await get_mobile_location01();
            if (res.success != true)
            {

                status_string = res.output;
                get_city_mobile01 = string.Empty;
                get_state_mobile01 = string.Empty;
                get_country_mobile01 = string.Empty;
                get_longitude_mobile = string.Empty;
                get_latitude_mobile = string.Empty;

            }
            else
            {
                string[] res_array = res.output.Split("\n");
                get_city_mobile01 = res_array[0];
                get_state_mobile01 = res_array[1];
                get_country_mobile01 = res_array[2];
                get_longitude_mobile = res_array[3];
                get_latitude_mobile = res_array[4];

            }

        }
        private async Task<(bool success, string output)> get_mobile_location01()
        {
            try
            {
                PermissionStatus permission = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
                if (permission != PermissionStatus.Granted)
                {
                    permission = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();


                }

                if (permission != PermissionStatus.Granted)
                {

                    return (false, "Location permission was not granted");

                }

                Location? location = await Geolocation.Default.GetLocationAsync(
                    new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(10)));

                if (location is not null)
                {
                    IEnumerable<Placemark>? placemarks = await Geocoding.Default.GetPlacemarksAsync(
                        location.Latitude,
                        location.Longitude);
                    Placemark? placemark = placemarks?.FirstOrDefault();

                    if (placemark is null)
                    {
                        return (false, "Unable to determine the city, state, or country");
                    }




                    return (true, $"City: {placemark.Locality ?? "Unknown"}\n" +
                                  $"State: {placemark.AdminArea ?? "Unknown"}\n" +
                                  $"Country: {placemark.CountryName ?? "Unknown"}\n" +
                                  $"Longitude: {location.Longitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}\n" +
                                  $"Latitude: {location.Latitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}");
                }
                else
                {

                    return (false, "Unable to get the device location");
                }
            }
            catch (FeatureNotSupportedException)
            {

                return (false, "Precise location is not supported on this device");
            }
            catch (PermissionException)
            {

                return (false, "Location permission was not granted");
            }
            catch (Exception ex)
            {

                return (false, $"Unable to get precise location\n {ex}");
            }
        }
    }
}