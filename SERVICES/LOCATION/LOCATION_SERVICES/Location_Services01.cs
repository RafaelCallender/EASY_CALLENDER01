using EASYPROJECT01.EASY_CALLENDER01.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_LANGUAGE_SERVICES;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_HELPER;
using System.Net.Http;
using System.Text.Json;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.LOCATION_MODEL.LOCATION_GET_MODEL;
namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_SERVICES
{
    public class Location_Services01
    {

        private static string[] data01 = new string[100];
        private List<string> type = new List<string>();
        private List<string> type01 = new List<string>();
        private List<double> bbox = new List<double>();
        private List<string> country = new List<string>();
        private List<string> country_code = new List<string>();
        private List<string> state = new List<string>();
        private List<string> city = new List<string>();
        private List<string> postcode = new List<string>();
        private List<string> suburb = new List<string>();
        private List<string> street = new List<string>();
        private List<string> housenumber = new List<string>();
        private List<string> iso3166_2 = new List<string>();
        private List<string> iso3166_2_sublevel = new List<string>();
        private List<double> lon = new List<double>();
        private List<double> lat = new List<double>();
        private List<string> state_code = new List<string>();
        private List<string> result_type = new List<string>();
        private List<string> formatted = new List<string>();
        private List<string> address_line1 = new List<string>();
        private List<string> address_line2 = new List<string>();
        private List<string> category = new List<string>();
        private List<string> plus_code = new List<string>();
        private List<string> plus_code_short = new List<string>();
        private List<string> place_id = new List<string>();
        private List<string> sourcename = new List<string>();
        private List<string> attribution = new List<string>();
        private List<string> license = new List<string>();
        private List<string> url = new List<string>();
        private List<string> name = new List<string>();
        private List<string> offset_STD = new List<string>();
        private List<string> offset_DST = new List<string>();
        private List<int> offset_STD_seconds = new List<int>();
        private List<int> offset_DST_seconds = new List<int>();
        private List<string> abbreviation_STD = new List<string>();
        private List<string> abbreviation_DST = new List<string>();
        private List<double> importance = new List<double>();
        private List<double> popularity = new List<double>();
        private List<int> confidence = new List<int>();
        private List<int> confidence_city_level = new List<int>();
        private List<int> confidence_street_level = new List<int>();
        private List<int> confidence_building_level = new List<int>();
        private List<string> match_type = new List<string>();
        private List<string> text = new List<string>();
        private List<string> housenumber01 = new List<string>();
        private List<string> street01 = new List<string>();
        private List<string> postcode01 = new List<string>();
        private List<string> city01 = new List<string>();
        private List<string> country01 = new List<string>();
        private List<string> expected_type = new List<string>();
        private List<string> type02 = new List<string>();
        private List<double> coordinates = new List<double>();
        private List<string> url01 = new List<string>();


        public async Task<string> GetLocationDataAsync01(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Location lookup failed: an address is required.";
            }

            using var client = new HttpClient();

            string web =
                $"https://api.geoapify.com/v1/geocode/autocomplete" +
                $"?text={Uri.EscapeDataString(input.Trim())}" +
                $"&format=json" +
                $"&apiKey={File_Manger01.API07.Trim()}";

            var response = await client.GetAsync(web.Trim());
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Location_Get_Model02.Root? results = JsonConvert.DeserializeObject<Location_Get_Model02.Root>(body);
            if (results == null)
            {
                return "Location lookup failed: the API returned an invalid response.";
            }

            type.Add(results?.type ?? "");
            text.Add(results.query?.text ?? "");
            foreach (var a in results.features ?? new List<Location_Get_Model02.Feature>())
            {
                var properties = a.properties;
                var datasource = properties?.datasource;
                var timezone = properties?.timezone;
                var rank = properties?.rank;

                type01.Add(a.type ?? "");
                sourcename.Add(datasource?.sourcename ?? "");
                attribution.Add(datasource?.attribution ?? "");
                license.Add(datasource?.license ?? "");
                url.Add(datasource?.url ?? "");
                country.Add(properties?.country ?? "");
                country_code.Add(properties?.country_code ?? "");
                state.Add(properties?.state ?? "");
                city.Add(properties?.city ?? "");
                postcode.Add(properties?.postcode ?? "");
                suburb.Add(properties?.suburb ?? "");
                street.Add(properties?.street ?? "");
                housenumber.Add(properties?.housenumber ?? "");
                iso3166_2.Add(properties?.iso3166_2 ?? "");
                iso3166_2_sublevel.Add(properties?.iso3166_2_sublevel ?? "");
                lon.Add(properties?.lon ?? 0);
                lat.Add(properties?.lat ?? 0);
                state_code.Add(properties?.state_code ?? "");
                result_type.Add(properties?.result_type ?? "");
                formatted.Add(properties?.formatted ?? "");
                address_line1.Add(properties?.address_line1 ?? "");
                address_line2.Add(properties?.address_line2 ?? "");
                category.Add(properties?.category ?? "");
                place_id.Add(properties?.place_id ?? "");
                name.Add(timezone?.name ?? "");
                offset_STD.Add(timezone?.offset_STD ?? "");
                offset_DST.Add(timezone?.offset_DST ?? "");
                offset_STD_seconds.Add(timezone?.offset_STD_seconds ?? 0);
                offset_DST_seconds.Add(timezone?.offset_DST_seconds ?? 0);
                abbreviation_STD.Add(timezone?.abbreviation_STD ?? "");
                abbreviation_DST.Add(timezone?.abbreviation_DST ?? "");
                plus_code.Add(properties?.plus_code ?? "");
                plus_code_short.Add(properties?.plus_code_short ?? "");
                importance.Add(rank?.importance ?? 0);
                popularity.Add(rank?.popularity ?? 0);
                confidence.Add(rank?.confidence ?? 0);
                confidence_city_level.Add(rank?.confidence_city_level ?? 0);
                confidence_street_level.Add(rank?.confidence_street_level ?? 0);
                confidence_building_level.Add(rank?.confidence_building_level ?? 0);
                match_type.Add(rank?.match_type ?? "");
                type02.Add(a.geometry?.type ?? "");
                foreach (double b in a.geometry?.coordinates ?? new List<double>())
                {
                    coordinates.Add(b);
                }
                foreach (double b in a.bbox ?? new List<double>())
                {
                    bbox.Add(b);
                }
            }
            housenumber01.Add(results.query?.parsed?.housenumber ?? "");
            street01.Add(results.query?.parsed?.street ?? "");
            postcode01.Add(results.query?.parsed?.postcode ?? "");
            city01.Add(results.query?.parsed?.city ?? "");
            country01.Add(results.query?.parsed?.country ?? "");
            expected_type.Add(results.query?.parsed?.expected_type ?? "");
            data01[1] = $"type: {string.Join(" ", type)}\n" +
            $"type01: {string.Join(" ", type01)}\n" +
               $"bbox: {string.Join(" ", bbox)}\n" +
               $"country: {string.Join(" ", country)}\n" +
               $"country_code: {string.Join(" ", country_code)}\n" +
               $"state: {string.Join(" ", state)}\n" +
               $"city: {string.Join(" ", city)}\n" +
               $"postcode: {string.Join(" ", postcode)}\n" +
               $"suburb: {string.Join(" ", suburb)}\n" +
               $"street: {string.Join(" ", street)}\n" +
               $"housenumber: {string.Join(" ", housenumber)}\n" +
               $"iso3166_2: {string.Join(" ", iso3166_2)}\n" +
               $"iso3166_2_sublevel: {string.Join(" ", iso3166_2_sublevel)}\n" +
               $"lon: {string.Join(" ", lon)}\n" +
               $"lat: {string.Join(" ", lat)}\n" +
               $"state_code: {string.Join(" ", state_code)}\n" +
               $"result_type: {string.Join(" ", result_type)}\n" +
               $"formatted: {string.Join(" ", formatted)}\n" +
               $"address_line1: {string.Join(" ", address_line1)}\n" +
               $"address_line2: {string.Join(" ", address_line2)}\n" +
               $"category: {string.Join(" ", category)}\n" +
               $"plus_code: {string.Join(" ", plus_code)}\n" +
               $"plus_code_short: {string.Join(" ", plus_code_short)}\n" +
               $"place_id: {string.Join(" ", place_id)}\n" +
               $"sourcename: {string.Join(" ", sourcename)}\n" +
               $"attribution: {string.Join(" ", attribution)}\n" +
               $"license: {string.Join(" ", license)}\n" +
               $"url: {string.Join(" ", url)}\n" +
               $"name: {string.Join(" ", name)}\n" +
               $"offset_STD: {string.Join(" ", offset_STD)}\n" +
               $"offset_DST: {string.Join(" ", offset_DST)}\n" +
               $"offset_STD_seconds: {string.Join(" ", offset_STD_seconds)}\n" +
               $"offset_DST_seconds: {string.Join(" ", offset_DST_seconds)}\n" +
               $"abbreviation_STD: {string.Join(" ", abbreviation_STD)}\n" +
               $"abbreviation_DST: {string.Join(" ", abbreviation_DST)}\n" +
               $"importance: {string.Join(" ", importance)}\n" +
               $"popularity: {string.Join(" ", popularity)}\n" +
               $"confidence: {string.Join(" ", confidence)}\n" +
               $"confidence_city_level: {string.Join(" ", confidence_city_level)}\n" +
               $"confidence_street_level: {string.Join(" ", confidence_street_level)}\n" +
               $"confidence_building_level: {string.Join(" ", confidence_building_level)}\n" +
               $"match_type: {string.Join(" ", match_type)}\n" +
               $"text: {string.Join(" ", text)}\n" +
               $"housenumber01: {string.Join(" ", housenumber01)}\n" +
               $"street01: {string.Join(" ", street01)}\n" +
               $"postcode01: {string.Join(" ", postcode01)}\n" +
               $"city01: {string.Join(" ", city01)}\n" +
               $"country01: {string.Join(" ", country01)}\n" +
               $"expected_type: {string.Join(" ", expected_type)}\n" +
               $"type02: {string.Join(" ", type02)}\n" +
               $"coordinates: {string.Join(" ", coordinates)}\n" +
               $"url: {string.Join(" ", url)}\n";
                 data01[2] =$"{city}\n" +
                            $"{state}\n" +
                            $"{country}\n" +
                            $"{lat}\n" +
                            $"{lon}\n";
            
            return data01[2];

        }


    }

}