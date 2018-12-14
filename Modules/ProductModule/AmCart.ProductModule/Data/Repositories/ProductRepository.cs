using AmCart.ProductModule.Domain;
using AmCart.Core.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using AmCart.Core.Data.DataAccess;
using AmCart.ProductModule.Data.DBContext;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AmCart.ProductModule.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context = null;

        public ProductRepository(IOptions<DBSettings> settings)
        {
            _context = new ProductDbContext(settings);
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            try
            {
                return await _context.Products
                        .Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
