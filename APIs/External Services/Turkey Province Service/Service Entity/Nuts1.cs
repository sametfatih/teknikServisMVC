using Newtonsoft.Json;
using teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Entity;

namespace teknikServisMVC.APIse.External_Services.Turkey_Province_Service.Service_Entity{ 
        
    public class Nuts1
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }
    }

}