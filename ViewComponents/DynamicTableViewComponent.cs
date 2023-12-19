using Microsoft.AspNetCore.Mvc;


namespace teknikServisMVC.ViewComponents
{
    public class DynamicTableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Tuple<object, List<object>, string> tuple)
        {
            return View(tuple);
        }
    }
    public class TableHeader
    {
        //Entity class names are converted to Turkish.
        public static string[] entity_names = new string[] { "Adres", "Cihaz", "İletişim", "Müşteri", "Arıza" };

        //property names are converted to Turkish.
        public static string[] Fault = { "Açıklama", "Cihaz", "Müşteri", "Takip No", "Oluşturulma Tarihi", "Güncellenme Tarihi", "Durumu" };
        public static string[] Address = { "Ülke", "Şehir", "Sokak/Cadde", "Posta Kodu", "Müşteri", "Oluşturulma Tarihi", "Güncellenme Tarihi", "Durumu" };
        public static string[] Contact = { "Numara", "E-posta", "Müşteri", "Oluşturulma Tarihi", "Güncellenme Tarihi", "Durumu" };
        public static string[] Customer = { "Ad", "Soyad", "Adres", "İletişim", "Oluşturulma Tarihi", "Güncellenme Tarihi", "Durumu" };
        public static string[] Device = { "Marka", "Model", "Seri Numarası", "Arıza", "Oluşturulma Tarihi", "Güncellenme Tarihi", "Durumu" };
        public static string[] FaultStatus = { "Ad", "Oluşturulma Tarihi", "Güncellenme Tarihi", "Durumu" };

        public static string UrlId(string name)
        {
            switch (name)
            {
                case "Ariza":
                    return "Fault";
                case "Adres":
                    return "Address";
                case "Iletisim":
                    return "Contact";
                case "Musteri":
                    return "Customer";
                case "Cihaz":
                    return "Device";
                case "ArizaDurumu":
                    return "FaultStatus";
                default:
                    // Belirtilen isimle eşleşen bir dizi yoksa, boş bir dizi döndürün veya isteğinize göre başka bir işlem yapın.
                    return null;
            }
        }


        public static string[] Get(string name)
        {
            switch (name)
            {
                case "Ariza":
                    return Fault;
                case "Adres":
                    return Address;
                case "Iletisim":
                    return Contact;
                case "Musteri":
                    return Customer;
                case "Cihaz":
                    return Device;
                case "ArizaDurumu":
                    return FaultStatus;
                default:
                    // Belirtilen isimle eşleşen bir dizi yoksa, boş bir dizi döndürün veya isteğinize göre başka bir işlem yapın.
                    return new string[0];
            }
        }
    }
}
