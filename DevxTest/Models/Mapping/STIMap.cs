using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevxTest.Models.Mapping
{
    public class STIMap : EntityTypeConfiguration<STI>
    {
        public STIMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IslemTur, t.EvrakNo, t.Tarih });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.IslemTur)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EvrakNo)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.Tarih)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MalKodu)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Birim)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("STI");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IslemTur).HasColumnName("IslemTur");
            this.Property(t => t.EvrakNo).HasColumnName("EvrakNo");
            this.Property(t => t.Tarih).HasColumnName("Tarih");
            this.Property(t => t.MalKodu).HasColumnName("MalKodu");
            this.Property(t => t.Miktar).HasColumnName("Miktar");
            this.Property(t => t.Fiyat).HasColumnName("Fiyat");
            this.Property(t => t.Tutar).HasColumnName("Tutar");
            this.Property(t => t.Birim).HasColumnName("Birim");
        }
    }
}
