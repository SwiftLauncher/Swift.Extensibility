using System;

namespace Swift.Extensibility.Input
{
    /// <summary>
    /// Represents a DataItem.
    /// </summary>
    public sealed class DataItem
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; private set; }

        /// <summary>
        /// Gets the display title.
        /// </summary>
        /// <value>
        /// The display title.
        /// </value>
        public string DisplayTitle { get; private set; }

        /// <summary>
        /// Gets the display subtitle.
        /// </summary>
        /// <value>
        /// The display subtitle.
        /// </value>
        public string DisplaySubtitle { get; private set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public ISwiftExtender Source { get; private set; }

        /// <summary>
        /// Gets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public object Content { get; private set; }

        /// <summary>
        /// Gets the execution callback.
        /// </summary>
        /// <value>
        /// The execution callback.
        /// </value>
        public Action<DataItem> ExecutionCallback { get; private set; }

        /// <summary>
        /// Prevents a default instance of the <see cref="DataItem"/> class from being created.
        /// </summary>
        private DataItem()
        {

        }

        /// <summary>
        /// Creates a new DataItem.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="displayTitle">The display title.</param>
        /// <param name="displaySubtitle">The display subtitle.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="content">The content.</param>
        /// <param name="executionCallback">The execution callback.</param>
        /// <returns></returns>
        public static DataItem Create(ISwiftExtender source, string displayTitle, string displaySubtitle = "", int id = 0, object content = null, Action<DataItem> executionCallback = null) => new DataItem { Source = source, Id = id, DisplayTitle = displayTitle, DisplaySubtitle = displaySubtitle, Content = content, ExecutionCallback = executionCallback };
    }
}
