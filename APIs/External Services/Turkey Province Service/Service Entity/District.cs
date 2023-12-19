using Newtonsoft.Json; 
namespace teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Entity{ 

    public class District
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("area")]
        public int? Area { get; set; }

        [JsonProperty("population")]
        public int? Population { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }
    }

}