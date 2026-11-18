using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using GoogleMaps.LocationServices;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_SERVICES
{
    public class Location_Services02
    {
        private static string[] data01 = new string[100];
        public async Task<string> GetLocationDataAsync(string input)
        {
            try
            {
                string apiKey = File_Manger01.API06.Trim();
                var geocoder = new GoogleLocationService(apiKey);
                var result = await geocoder.GetLatLongFromAddressAsync(input);

                if (result != null)
                {
                    data01[1] = $"{result.Latitude}\n" +
                               $"{result.Longitude}";

                    return data01[1];
                }

                return "Address not found.";
            }
            catch (Exception ex)
            {
                return $"Location lookup failed: {ex.Message}";
            }
        }
    }
}
