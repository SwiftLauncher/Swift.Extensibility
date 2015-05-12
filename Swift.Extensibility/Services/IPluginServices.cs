using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;
using Swift.Extensibility.Services;
using Swift.Extensibility.Services.Settings;
using Swift.Extensibility.UI;

namespace Swift.Extensibility
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
        /// <param name="cardinality">The cardinality.</param>
        /// <returns>A list of all services of the requested type.</returns>
        /// <remarks>Only types that have been configured as valid services can be requested using this function.</remarks>
        IEnumerable<TService> GetServices<TService>();

        #endregion

        #region Settings and User

        ISettingsStore GetSettingsStore<TPlugin>();

        IUserProfile GetCurrentUser();

        #endregion
    }
}
