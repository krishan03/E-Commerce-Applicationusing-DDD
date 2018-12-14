using AmCart.ProductModule.Domain;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.ProductModule.Data.DBContext
{
    public class ProductDbContext
    {
        private readonly IMongoDatabase _database = null;


        public ProductDbContext(IOptions<DBSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Product> Products
        {
            get
            {
                return _database.GetCollection<Product>("Product");
            }
        }
    }
}
