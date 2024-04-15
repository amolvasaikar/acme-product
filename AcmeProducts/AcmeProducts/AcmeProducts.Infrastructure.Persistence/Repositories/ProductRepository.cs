using AcmeProducts.Application.DTOs;
using AcmeProducts.Application.Interfaces.Repositories;
using AcmeProducts.Domain.Products.Dtos;
using AcmeProducts.Domain.Products.Entities;
using AcmeProducts.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeProducts.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DbSet<Product> products;

        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            products = dbContext.Set<Product>();

        }

        public async Task<PagenationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = products.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.ProductName.Contains(name));
            }

            return await Paged(
                query.Select(p => new ProductDto(p)),
                pageNumber,
                pageSize);

        }
    }
}
