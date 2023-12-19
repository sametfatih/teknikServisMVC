using Newtonsoft.Json; 
namespace teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Entity{ 

    public class Maps
    {
        [JsonProperty("googleMaps")]
        public string GoogleMaps { get; set; }

        [JsonProperty("openStreetMap")]
        public string OpenStreetMap { get; set; }
    }

}