using AcmeProducts.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using AcmeProducts.Domain.Products.Entities;

namespace AcmeProducts.Domain.ProductLines.Entities
{
    public class ProductLine : AuditableBaseEntity
    {
        private ProductLine()
        {
        }

        public ProductLine(string productLineName,string textDescription, string htmlDescription,string image)
        {
            ProductLineName = productLineName;
            TextDescription = textDescription;
            HtmlDescription = htmlDescription;
            Image = image;
        }

        public string ProductLineName { get; private set; }
        public string? TextDescription { get; private set; }
        public string? HtmlDescription { get; private set; }
        public string? Image { get; private set; }

        public ICollection<Product> Products { get; set; }

        public void Update(string productLineName, string textDescription, string htmlDescription, string image)
        {
            ProductLineName = productLineName;
            TextDescription = textDescription;
            HtmlDescription = htmlDescription;
            Image = image;
        }
    }
}