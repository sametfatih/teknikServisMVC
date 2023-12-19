using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Entity;

namespace teknikServisMVC.APIs.External_Services.Turkey_Province_Service.Service_Client
{
    public class ServiceClient
    {

        public static List<Datum> GetProvinces()
        {
           var  _httpClient = new HttpClient();
            var httpResponseMessage =  _httpClient.GetAsync("https://turkiyeapi.dev/api/v1/provinces").Result;
            var jsonResult = httpResponseMessage.Content.ReadAsStringAsync().Result;
            var result_list = JsonConvert.DeserializeObject<Root>(jsonResult);
            _httpClient.Dispose();
            if(result_list != null)
                return result_list.Data;
            else
            {
                return new List<Datum>();
            }
        }
    }
}
