using System.IO;

namespace Swift.Extensibility.Services.Storage
{
    /// <summary>
    /// Allows access to Swift storage locations.
    /// </summary>
    public interface IStorageManager
    {
        /// <summary>
        /// Gets the plugins directory.
        /// </summary>
        /// <value>
        /// The plugins directory.
        /// </value>
        DirectoryInfo PluginsDirectory { get; }

        /// <summary>
        /// Gets the application directory.
        /// </summary>
        /// <value>
        /// The application directory.
        /// </value>
        DirectoryInfo ApplicationDirectory { get; }
    }
}
