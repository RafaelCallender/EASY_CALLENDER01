using EASYPROJECT01.EASY_CALLENDER01.MODEL.LOCATION_MODEL.LOCATION_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using Newtonsoft.Json;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_SERVICES
{
    public class Location_Services03
    {
        private string[] data01 = new string[100];
        private int place_id = 0;
        private string licence = string.Empty;
        private string osm_type = string.Empty;
        private int osm_id = 0;
        private string lat = string.Empty;
        private string lon = string.Empty;
        private string @class = string.Empty;
        private string type = string.Empty;
        private int place_rank = 0;
        private double importance = 0;
        private string addresstype = string.Empty;
        private string name = string.Empty;
        private string display_name = string.Empty;
        private object extratags = string.Empty;
        private string road = string.Empty;
        private string neighbourhood = string.Empty;
        private string suburb = string.Empty;
        private string city = string.Empty;
        private string county = string.Empty;
        private string state = string.Empty;
        private string ISO31662lvl4 = string.Empty;
        private string postcode = string.Empty;
        private string country = string.Empty;
        private string country_code = string.Empty;
        private string boundingbox = string.Empty;
        private string name01 = string.Empty;
        public async Task<string> GetCoordinates(string address)
        {
            string apiKey = File_Manger01.API08?.Trim() ?? string.Empty;
            string url =
                $"https://geocode.maps.co/search?q={Uri.EscapeDataString(address.Trim())}" +
                $"&api_key={Uri.EscapeDataString(apiKey)}";

            using HttpClient client = new HttpClient();
            using (var response = await client.GetAsync(url))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Location_Get_Model03.Root? results = JsonConvert.DeserializeObject<List<Location_Get_Model03.Root>>(body)?.FirstOrDefault();
                if (results is null)
                {
                    return "Location lookup failed: no results found.";
                }
                else
                {
                    place_id = results.place_id;
                    licence = results.licence;
                    osm_type = results.osm_type;
                    osm_id = results.osm_id;
                    lat = results.lat;
                    lon = results.lon;
                    @class = results.@class;
                    type = results.type;
                    place_rank = results.place_rank;
                    importance = results.importance;
                    addresstype = results.addresstype;
                    name = results.name;
                    display_name = results.display_name;
                    road = results.address?.road;
                    neighbourhood = results.address?.neighbourhood;
                    suburb = results.address?.suburb;
                    city = results.address?.city;
                    county = results.address?.county;
                    state = results.address?.state;
                    ISO31662lvl4 = results.address?.ISO31662lvl4;
                    postcode = results.address?.postcode;
                    country = results.address?.country;
                    country_code = results.address?.country_code;
                    extratags = results.extratags;
                    name01 = results.namedetails?.name;
                    boundingbox = string.Join("\n", results.boundingbox ?? new List<string>());


                    data01[1] += $"place_id: {place_id}\n" +
                         $"licence: {licence}\n" +
                         $"osm_type: {osm_type}\n" +
                         $"osm_id: {osm_id}\n" +
                         $"lat: {lat}\n" +
                         $"lon: {lon}\n" +
                         $"class: {@class}\n" +
                         $"type: {type}\n" +
                         $"place_rank: {place_rank}\n" +
                         $"importance: {importance}\n" +
                         $"addresstype: {addresstype}\n" +
                         $"name: {name}\n" +
                         $"display_name: {display_name}\n" +
                         $"road: {road}\n" +
                         $"neighbourhood: {neighbourhood}\n" +
                         $"suburb: {suburb}\n" +
                         $"city: {city}\n" +
                         $"county: {county}\n" +
                         $"state: {state}\n" +
                         $"ISO31662lvl4: {ISO31662lvl4}\n" +
                         $"postcode: {postcode}\n" +
                         $"country: {country}\n" +
                         $"country_code: {country_code}\n" +
                         $"extratags: {extratags}\n" +
                         $"name01: {name01}\n" +
                         $"boundingbox: {boundingbox}\n";
                    data01[2] = $"{city}\n" +
                                $"{state}\n" +
                                $"{county}\n" +
                                $"{lat}\n" +
                                $"{lon}\n";

                    return data01[2];


                }

            }
        }
    }
}
