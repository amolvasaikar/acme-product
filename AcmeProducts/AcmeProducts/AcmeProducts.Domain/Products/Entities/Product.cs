using AcmeProducts.Domain.Common;
using AcmeProducts.Domain.ProductLines.Entities;

namespace AcmeProducts.Domain.Products.Entities
{
    public class Product : AuditableBaseEntity
    {
        private Product()
        {
        }
        public Product(string productName, double buyPrice, string msrp ,long productLineId , string productCode, 
            string productScale, string productVendor , string productDescription , int quantityInStock)
        {
            ProductName = productName;
            BuyPrice = buyPrice;
            MSRP = msrp;
            ProductLineId = productLineId;
            ProductCode = productCode;
            ProductScale = productScale;
            ProductVendor = productVendor;
            ProductDescription = productDescription;
            QuantityInStock = quantityInStock;
            BuyPrice = buyPrice;
        }
        public string ProductCode { get; private set; }
        public string ProductName { get; private set; }
        public string? ProductScale { get; private set; }
        public string? ProductVendor { get; private set; }
        public string? ProductDescription { get; private set; }
        public int? QuantityInStock { get; private set; }

        public double BuyPrice { get; private set; }
        public string MSRP { get; private set; }
        public long ProductLineId { get; set; }

        public ProductLine ProductLine { get; set; }
        public void Update(string productName, double buyPrice, string msrp, long productLineId, string productCode,
            string productScale, string productVendor, string productDescription, int quantityInStock)
        {
            ProductName = productName;
            BuyPrice = buyPrice;
            MSRP = msrp;
            ProductLineId = productLineId;
            ProductCode = productCode;
            ProductScale = productScale;
            ProductVendor = productVendor;
            ProductDescription = productDescription;
            QuantityInStock = quantityInStock;
            BuyPrice = buyPrice;
        }
    }
}
