using AmCart.Core.AppServices;
using AmCart.Core.ValueObjects;
using AmCart.ProductModule.AppServices.DTOs;
using AmCart.ProductModule.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmCart.ProductModule.AppServices
{
    public interface IProductAppService : IAppService
    {
        //OperationResult<ProductDTO> Create(ProductDTO item);
         Task<OperationResult<IEnumerable<Product>>> GetAllProductsAsync();
    }
}
