using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcmeProducts.Application.Wrappers;
using MediatR;

namespace AcmeProducts.Application.Features.ProductLines.Command.CreateProductLine
{
    public class CreateProductLineCommand  : IRequest<BaseResult<long>>
    {
        public string ProductLineName { get; private set; }
        public string TextDescription { get; private set; }
        public string HtmlDescription { get; private set; }
        public string Image { get; private set; }
    }
}
