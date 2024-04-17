using AcmeProducts.Domain.Products.Entities;

namespace AcmeProducts.Domain.Products.Dtos
{
    public class ProductDto
    {
        public ProductDto()
        {
        }

        public ProductDto(Product product)
        {
            Id = product.Id;
            ProductName = product.ProductName;
            ProductLineId = product.ProductLineId;
            ProductCode = product.ProductCode;
            ProductScale = product.ProductScale;
            ProductVendor = product.ProductVendor;
            ProductDescription = product.ProductDescription;
            QuantityInStock = product.QuantityInStock;
            BuyPrice = product.BuyPrice;
            MSRP = product.MSRP;
        }
        public long Id { get; set; }
        public string ProductCode { get; private set; }
        public string ProductName { get; private set; }
        public string? ProductScale { get; private set; }
        public string? ProductVendor { get; private set; }
        public string? ProductDescription { get; private set; }
        public int? QuantityInStock { get; private set; }

        public double BuyPrice { get; private set; }
        public string MSRP { get; private set; }
        public long ProductLineId { get; set; }

    }
}
