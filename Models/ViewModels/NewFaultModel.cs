using System.Text.Json.Serialization;

namespace teknik_servis.WebApp.Models
{
    public class NewFaultModel
    {
        public string Aciklama { get; set; } 
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SeriNumarasi { get; set; }
        public string Eposta { get; set; }
        public string ArizaTakipNumarasi{ get; set; }

    }
}
