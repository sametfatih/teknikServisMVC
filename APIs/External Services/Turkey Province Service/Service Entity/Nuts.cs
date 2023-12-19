using Newtonsoft.Json;
using teknikServisMVC.APIse.External_Services.Turkey_Province_Service.Service_Entity;

namespace teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Entity{ 

    public class Nuts
    {
        [JsonProperty("nuts1")]
        public Nuts1 Nuts1 { get; set; }

        [JsonProperty("nuts2")]
        public Nuts2 Nuts2 { get; set; }

        [JsonProperty("nuts3")]
        public string Nuts3 { get; set; }
    }

}