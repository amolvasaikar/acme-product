using AcmeProducts.Application.DTOs;
using AcmeProducts.Domain.Products.Dtos;
using AcmeProducts.Domain.Products.Entities;
using System.Threading.Tasks;

namespace AcmeProducts.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PagenationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
