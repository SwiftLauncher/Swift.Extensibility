using System;
using System.ComponentModel.Composition;

namespace Swift.Extensibility.Services
{
    /// <summary>
    /// Interface for initialization-aware components.
    /// </summary>
    [InheritedExport]
    public interface IInitializationAware
    {
        /// <summary>
        /// Gets the initialization priority. Higher values lead to later initialization.
        /// </summary>
        /// <value>
        /// The initialization priority.
        /// </value>
        int InitializationPriority { get; }

        /// <summary>
        /// Handles the <see cref="E:Initialization" /> event.
        /// </summary>
        /// <param name="args">The <see cref="InitializationEventArgs"/> instance containing the event data.</param>
        void OnInitialization(InitializationEventArgs args);
    }

    /// <summary>
    /// The initialization event args.
    /// </summary>
    public class InitializationEventArgs : EventArgs { }
}
