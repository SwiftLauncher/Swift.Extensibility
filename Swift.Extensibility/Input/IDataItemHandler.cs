using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Threading;
using System.Threading.Tasks;
using Swift.Extensibility.Input;

namespace Swift.Extensibility.Input
{
    /// <summary>
    /// Interface for DataItemHandlers.
    /// </summary>
    public interface IDataItemHandler
    {
        /// <summary>
        /// Gets the currently used matcher.
        /// </summary>
        /// <value>
        /// The matcher.
        /// </value>
        IDataItemMatcher Matcher { get; }

        /// <summary>
        /// Gets the currently used rater.
        /// </summary>
        /// <value>
        /// The rater.
        /// </value>
        IDataItemRater Rater { get; }

        /// <summary>
        /// Gets the matching items asynchronously. Subsequent calls to this method will cancel the currently running call and start new.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="items">The items.</param>
        /// <param name="cancellationToken">The cancellation token. Abort any operation if this cancellation is requested.</param>
        Task GetMatchingItemsAsync(IInput input, ref IList<DataItem> items, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the best match asynchronously.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The best matching DataItem for the given input.</returns>
        Task<DataItem> GetBestMatchAsync(IInput input);
    }
}
