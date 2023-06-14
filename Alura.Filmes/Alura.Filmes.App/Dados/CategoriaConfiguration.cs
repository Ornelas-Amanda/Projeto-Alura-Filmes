using System;

public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.ToTable("category");
        builder.Property(c => c.Id)
            .HasColumnName("category_id");
        builder.Property(c => c.Nome)
            .HasColumnName("name")
            .HasColumnType("varchar(25)")
            .IsRequired();
        builder.Property<DateTime>("last_update")
            .HasColumnType("datetime")
            .HasDefaultValueSql("getdate()");
    }
}