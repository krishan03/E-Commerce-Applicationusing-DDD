using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.Core.Domain.Domain
{
    public class DynamicCategory : DomainBase
    {
        public string Name { get; set; }

        public DynamicCategoryType Type { get; set; }

        public DateTime Expiry { get; set; }

        public string Value { get; set; }

        public ValueType ValueType { get; set; }
    }
}
