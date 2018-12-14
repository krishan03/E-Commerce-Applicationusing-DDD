using AmCart.Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.ProductModule.Domain
{
    public class TagGroup : DomainBase
    {
        public string Name { get; set; }

        public List<string> Tags { get; set; }
    }
}
