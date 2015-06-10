using System.Collections.Generic;
using Swift.Extensibility.Plugins;
using Swift.Extensibility.Services.Profile;
using Swift.Extensibility.Services.Settings;

namespace Swift.Extensibility.Services
{
    /// <summary>
    /// Interface for the plugin service component of Swift.
    /// </summary>
    public interface IPluginServices
    {
        #region Service Discovery

        /// <summary>
        /// Gets a service of the requested type.
        /// </summary>
        /// <typeparam name="TService">The type of the service.</typeparam>
        /// <returns>An implementation of the requested service type.</returns>
        /// <remarks>Only types that have been configured as valid services can be requested using this function.</remarks>
        TService GetService<TService>();

        /// <summary>
        /// Gets all services of the requested type.
        /// </summary>
        /// <typeparam name="TService">The type of the service.</typeparam>
        /// <returns>A list of all services of the requested type.</returns>
        /// <remarks>Only types that have been configured as valid services can be requested using this function.</remarks>
        IEnumerable<TService> GetServices<TService>();

        #endregion

        #region Settings and User

        /// <summary>
        /// Retrieves the settingsstore for the given plugin type.
        /// </summary>
        /// <typeparam name="TPlugin">The type of the plugin that requests the settings store.</typeparam>
        /// <returns>The <see cref="ISettingsStore"/>.</returns>
        ISettingsStore GetSettingsStore<TPlugin>() where TPlugin : IPlugin;

        /// <summary>
        /// Retrieves the current user profile.
        /// </summary>
        /// <returns>The current user profile.</returns>
        UserProfile GetCurrentUser();

        #endregion
    }
}
