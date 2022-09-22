using örnek.Entities;
using System.Data.Entity.ModelConfiguration;

namespace örnek.Contexts
{
    public class UrunlerTable : EntityTypeConfiguration<Urunler>
    {
        public UrunlerTable()
        {
            this.HasKey(t => t.UrunId);

            this.Property(t => t.UrunAdi)
                .IsRequired()
                .HasMaxLength(50);

            this.ToTable("Ürünler");
            this.Property(t => t.UrunId).HasColumnName("ÜrünId");
            this.Property(t => t.UrunAdi).HasColumnName("ÜrünAdı");

        }
    }
}
