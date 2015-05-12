using System.ComponentModel.Composition;

namespace Swift.Extensibility.Input
{
    /// <summary>
    /// Interface for DataItem matchers.
    /// </summary>
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
