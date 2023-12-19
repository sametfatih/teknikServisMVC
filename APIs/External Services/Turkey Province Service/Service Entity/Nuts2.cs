using Newtonsoft.Json; 
namespace teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Entity{ 

    public class Nuts2
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}