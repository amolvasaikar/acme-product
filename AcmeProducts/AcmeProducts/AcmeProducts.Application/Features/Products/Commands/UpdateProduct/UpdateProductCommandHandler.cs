﻿using AcmeProducts.Application.Helpers;
using AcmeProducts.Application.Interfaces;
using AcmeProducts.Application.Interfaces.Repositories;
using AcmeProducts.Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AcmeProducts.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<UpdateProductCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);

            if (product is null)
            {
                return new BaseResult(new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_notfound_with_id(request.Id)), nameof(request.Id)));
            }

            product.Update(request.ProductName, request.BuyPrice, request.MSRP, request.ProductLineId, request.ProductCode,
                request.ProductScale, request.ProductVendor, request.ProductDescription, request.QuantityInStock.Value);
            await unitOfWork.SaveChangesAsync();

            return new BaseResult();
        }
    }
}