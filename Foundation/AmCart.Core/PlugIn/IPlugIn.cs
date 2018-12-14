using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.Core.PlugIn
{
    /// <summary>
    /// Defines the contract for plugin implementations
    /// </summary>
    public interface IPlugIn
    {
        string Name { get; }
    }
}
