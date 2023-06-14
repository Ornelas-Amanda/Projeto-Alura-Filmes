using Alura.Filmes.App.Negocio;
using System;

namespace Alura.Filmes.App.Dados
{
    public class IdiomaConfiguration : IEntityTypeConfiguration<Idioma>
    {
        public void Configure(EntityTypeBuilder<Idioma> builder)
        {
            builder.ToTable("langauge");

            builder.Property(i => i.Id)
                .HasColumnName("language_id");
                .HasColumnType("char(20)")
                .IsRequired();

            builder.Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")

        }
    }
}