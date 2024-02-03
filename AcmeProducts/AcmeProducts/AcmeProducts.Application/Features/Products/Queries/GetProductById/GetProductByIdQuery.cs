using AcmeProducts.Application.Wrappers;
using AcmeProducts.Domain.Products.Dtos;
using MediatR;

namespace AcmeProducts.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
