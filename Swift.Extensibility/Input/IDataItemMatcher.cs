using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift.Extensibility.Input
{
    /// <summary>
    /// Interface for DataItem matchers.
    /// </summary>
    [InheritedExport]
    public interface IDataItemMatcher
    {
        /// <summary>
        /// Gets or sets the threshold certainty, above which a DataItem is considered matching.
        /// </summary>
        /// <value>
        /// The threshold certainty.
        /// </value>
        int ThresholdCertainty { get; set; }

        /// <summary>
        /// Gets the match certainty value for the given DataItem.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        int GetCertainty(DataItem item, IInput input);

        /// <summary>
        /// Determines whether the specified item is a match for the given input.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        bool IsMatch(DataItem item, IInput input);
    }
}
