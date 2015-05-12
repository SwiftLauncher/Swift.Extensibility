using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift.Extensibility.Input
{
    /// <summary>
    /// Interface for DataItem rating services.
    /// </summary>
    [InheritedExport]
    public interface IDataItemRater
    {
        /// <summary>
        /// Rates the specified item regarding the given input.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="input">The input.</param>
        /// <returns>A value indicating the rank of the DataItem regarding the given input.</returns>
        int Rate(DataItem item, IInput input);
    }
}
