using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace demoSwaggerCore.Modelos
{
    public partial class BEPENSAContext : DbContext
    {
        public virtual DbSet<Cliente> Cliente { get; set; }

        public BEPENSAContext(DbContextOptions<BEPENSAContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BEPENSA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApellidoMaterno)
                    .HasColumnName("apellidoMaterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasColumnName("apellidoPaterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia).HasColumnName("colonia");

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionCalleContato)
                    .HasColumnName("direccionCalleContato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionNumeroContacto)
                    .HasColumnName("direccionNumeroContacto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Municipio).HasColumnName("municipio");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pais).HasColumnName("pais");

                entity.Property(e => e.Preferente).HasColumnName("preferente");

                entity.Property(e => e.TipoPersona)
                    .HasColumnName("tipoPersona")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
