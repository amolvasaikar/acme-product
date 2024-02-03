using AcmeProducts.Application.Parameters;
using AcmeProducts.Application.Wrappers;
using AcmeProducts.Domain.Products.Dtos;
using MediatR;

namespace AcmeProducts.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PagenationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
