using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Entity{ 

    public class Root
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }

}