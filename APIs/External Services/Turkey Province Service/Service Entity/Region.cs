using Newtonsoft.Json; 
namespace teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Entity{ 

    public class Region
    {
        [JsonProperty("en")]
        public string En { get; set; }

        [JsonProperty("tr")]
        public string Tr { get; set; }
    }

}