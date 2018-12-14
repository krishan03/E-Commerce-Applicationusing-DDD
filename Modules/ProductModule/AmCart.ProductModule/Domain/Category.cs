using AmCart.Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.ProductModule.Domain
{
    public class Category : DomainBase
    {
        public string Name { get; set; }

        public List<Category> SubCategories { get; set; }
    }
}
