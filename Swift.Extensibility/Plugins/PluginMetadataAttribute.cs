using System;
using System.ComponentModel.Composition;

namespace Swift.Extensibility.Plugins
{
    /// <summary>
    /// Represents an attribute for exporting Swift plugins.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class PluginMetadataAttribute : Attribute, IPluginMetadata
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Gets the version.
        /// </summary>
        public string Version { get; }
        /// <summary>
        /// Gets the description.
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Gets the help URI.
        /// </summary>
        public string HelpUri { get; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        public string ID { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginMetadataAttribute" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="version">The version.</param>
        /// <param name="description">The description.</param>
        /// <param name="helpUri">The help URI.</param>
        /// <param name="id">The identifier of the plugin (get this from the Spec Developer Experience).</param>
        public PluginMetadataAttribute(string name, string version, string description, string helpUri, string id)
        {
            Name = name;
            Version = version;
            Description = description;
            HelpUri = helpUri;
            ID = id;
        }
    }
}
