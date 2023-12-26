# Teknik Servis Yönetim Sistemi - Admin Şablonu

Bu proje, teknik servis işlemlerini yönetmek için tasarlanmış bir web uygulamasıdır. .NET MVC mimarisi, MSSQL veritabanı, Bootstrap ile arayüz tasarımı ve Entity Framework ile veritabanı migration işlemleri kullanılarak geliştirilmiştir.

## Başlarken

Bu bölümde, projenin nasıl yerel bir makinede kurulup çalıştırılacağına dair adımlar bulunmaktadır.

### Önkoşullar

Projeyi çalıştırmadan önce aşağıdaki araçların sisteminizde kurulu olduğundan emin olun:

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Microsoft SQL Server](https://www.microsoft.com/tr-tr/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/tr/downloads/) (Tavsiye edilen IDE)

### Kurulum

1. **Reposity'yi Klonlayın**

   Projeyi yerel makinenize klonlamak için:

   ```bash
   git clone https://github.com/sametfatih/teknikServisMVC.git
   cd teknikServisMVC
   ```

2. **Veritabanı Ayarlarını Yapılandırın**

   `appsettings.json` dosyasını açın ve `ConnectionStrings` bölümünü kendi MSSQL sunucu bilgilerinize göre düzenleyin.

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_username;Password=your_password;"
   }
   ```

3. **Veritabanı Migration'larını Uygulayın**

   Veritabanını oluşturmak ve ilk migration'ları uygulamak için aşağıdaki komutları kullanın:

   ```bash
   dotnet ef database update
   ```

4. **Uygulamayı Çalıştırın**

   Visual Studio'da, projeyi açın ve 'IIS Express' butonuna tıklayarak uygulamayı başlatın.

## Kullanılan Teknolojiler

- **.NET MVC**: Sunucu tarafı uygulama mantığı için.
- **Entity Framework**: Veritabanı işlemleri için ORM aracı.
- **MSSQL**: Veritabanı yönetim sistemi.
- **Bootstrap**: Responsive ve modern arayüz tasarımı için.
- **Migration**: Veritabanı şemasını sürüm kontrolü altında tutmak ve güncellemek için.

## Özellikler

- Teknik servis taleplerinin yönetimi.
- Müşteri bilgilerinin kaydı ve yönetimi.
- Cihaz ve servis geçmişi bilgilerinin takibi.
- Raporlama ve analiz araçları.

## Katkıda Bulunma

Projeye katkıda bulunmak isteyenler için:

1. Projeyi forklayın ve kendi branch'inizi oluşturun (`git checkout -b feature/AmazingFeature`).
2. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`).
3. Branch'inizi Push edin (`git push origin feature/AmazingFeature`).
4. Bir Pull Request oluşturun.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır - daha fazla detay için [LICENSE.md](LICENSE.md) dosyasına bakınız.
