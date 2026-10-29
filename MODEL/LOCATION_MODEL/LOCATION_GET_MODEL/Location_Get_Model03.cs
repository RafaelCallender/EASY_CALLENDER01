using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json;
//https://geocode.maps.co/account/

namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.LOCATION_MODEL.LOCATION_GET_MODEL
{
    public class Location_Get_Model03
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

        public class Address
        {
            public string road { get; set; }
            public string neighbourhood { get; set; }
            public string suburb { get; set; }
            public string city { get; set; }
            public string county { get; set; }
            public string state { get; set; }

            [JsonProperty("ISO3166-2-lvl4")]
            public string ISO31662lvl4 { get; set; }
            public string postcode { get; set; }
            public string country { get; set; }
            public string country_code { get; set; }
        }

        public class Namedetails
        {
            public string name { get; set; }
        }

        public class Root
        {
            public int place_id { get; set; }
            public string licence { get; set; }
            public string osm_type { get; set; }
            public int osm_id { get; set; }
            public string lat { get; set; }
            public string lon { get; set; }
            public string @class { get; set; }
            public string type { get; set; }
            public int place_rank { get; set; }
            public double importance { get; set; }
            public string addresstype { get; set; }
            public string name { get; set; }
            public string display_name { get; set; }
            public Address address { get; set; }
            public object extratags { get; set; }
            public Namedetails namedetails { get; set; }
            public List<string> boundingbox { get; set; }
        }

    }
}