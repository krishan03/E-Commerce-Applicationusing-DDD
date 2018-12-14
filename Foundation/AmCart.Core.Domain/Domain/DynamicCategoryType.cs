using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.Core.Domain.Domain
{
    public class DynamicCategoryType : DomainBase
    {
        public string Name { get; set; }

        public bool IsExclusive { get; set; }
    }
}
