using System;
using System.Threading;
using System.Threading.Tasks;
using AcmeProducts.Application.Features.Products.Commands.CreateProduct;
using AcmeProducts.Application.Wrappers;
using MediatR;

namespace AcmeProducts.Application.Features.ProductLines.Command.CreateProductLine;

public class CreateProductLineCommandHandler : IRequestHandler<CreateProductCommand, BaseResult<long>>
{
    public CreateProductLineCommandHandler()
    {
            
    }
    public Task<BaseResult<long>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}