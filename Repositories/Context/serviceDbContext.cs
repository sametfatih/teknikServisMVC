using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using teknikServisMVC.Models.Entities.Abstract;
using teknikServisMVC.Models.Entities.Concrete;

namespace teknikServisMVC.Repositories.Context
{
    public class serviceDbContext : DbContext
    {
        public serviceDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public virtual DbSet<Cihaz> Cihazlar { get; set; }
        public virtual DbSet<Ariza> Arizalar { get; set; }
        public virtual DbSet<ArizaDurumu> ArizaDurum { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Iletisim> Iletisimler { get; set; }
        public virtual DbSet<Adres> Adresler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseLazyLoadingProxies(); // veya optionsBuilder.UseChangeTrackingProxies();
                                                    // Diğer konfigürasyonlar...
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ariza>()
                .HasOne(a => a.Cihaz)
                .WithOne(c => c.Ariza)
                .HasForeignKey<Cihaz>(c => c.ArizaId);

            // Diğer ilişkileri tanımlayın...

            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State
                switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
