using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Entity{ 

    public class Datum
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("area")]
        public int? Area { get; set; }

        [JsonProperty("population")]
        public int? Population { get; set; }

        [JsonProperty("altitude")]
        public int? Altitude { get; set; }

        [JsonProperty("areaCode")]
        public List<int?> AreaCode { get; set; }

        [JsonProperty("isMetropolitan")]
        public bool? IsMetropolitan { get; set; }

        [JsonProperty("nuts")]
        public Nuts Nuts { get; set; }

        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("maps")]
        public Maps Maps { get; set; }

        [JsonProperty("region")]
        public Region Region { get; set; }

        [JsonProperty("districts")]
        public List<District> Districts { get; set; }
    }

}