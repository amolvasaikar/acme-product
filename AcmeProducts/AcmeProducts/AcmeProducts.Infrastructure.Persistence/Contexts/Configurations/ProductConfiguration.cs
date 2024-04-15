using AcmeProducts.Domain.ProductLines.Entities;
using AcmeProducts.Domain.Products.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcmeProducts.Infrastructure.Persistence.Contexts.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.ProductName).HasMaxLength(100);

            builder.HasOne(e => e.ProductLine)
                   .WithMany(e => e.Products)
                   .HasForeignKey(e => e.ProductLineId)
                   .IsRequired();
        }
    }
}