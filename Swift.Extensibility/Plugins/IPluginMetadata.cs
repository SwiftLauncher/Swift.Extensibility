namespace Swift.Extensibility.Plugins
{
    /// <summary>
    /// Represents the plugin metadata.
    /// </summary>
    public interface IPluginMetadata
    {
        /// <summary>
        /// Gets the name of the plugin.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Gets the version of the plugin.
        /// </summary>
        string Version { get; }
        /// <summary>
        /// Gets the description of the plugin.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Gets the help URI.
        /// </summary>
        string HelpUri { get; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        string ID { get; }
    }
}
