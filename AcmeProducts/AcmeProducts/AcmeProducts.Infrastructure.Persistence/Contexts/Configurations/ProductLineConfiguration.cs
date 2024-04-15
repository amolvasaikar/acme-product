using AcmeProducts.Domain.ProductLines.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcmeProducts.Infrastructure.Persistence.Contexts.Configurations;

public class ProductLineConfiguration : IEntityTypeConfiguration<ProductLine>
{

    public void Configure(EntityTypeBuilder<ProductLine> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(p => p.ProductLineName).HasMaxLength(100);
        builder.Property(p => p.TextDescription).HasMaxLength(1000);
        builder.Property(p => p.HtmlDescription).HasMaxLength(1000);
    }
}