using Newtonsoft.Json; 
namespace teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Entity
{ 

    public class Coordinates
    {
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
    }


}