using AcmeProducts.Application.Wrappers;
using MediatR;

namespace AcmeProducts.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<BaseResult<long>>
    {
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
