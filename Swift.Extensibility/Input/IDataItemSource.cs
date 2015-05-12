using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift.Extensibility.Input
{
    /// <summary>
    /// Interface for sources of DataItems.
    /// </summary>
    [InheritedExport]
    public interface IDataItemSource
    {
        /// <summary>
        /// Gets the matching items for the given input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The matching items for the given input.</returns>
        IEnumerable<DataItem> GetMatchingItems(IInput input);
    }
}
