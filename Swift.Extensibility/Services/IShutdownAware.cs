using System;
using System.ComponentModel.Composition;

namespace Swift.Extensibility.Services
{
    [InheritedExport]
    public interface IShutdownAware
    {
        /// <summary>
        /// Gets the shutdown priority. Higher values lead to later shutdown.
        /// </summary>
        /// <value>
        /// The shutdown priority.
        /// </value>
        int ShutdownPriority { get; }

        /// <summary>
        /// Handles the <see cref="E:Shutdown" /> event.
        /// </summary>
        /// <param name="args">The <see cref="ShutdownEventArgs"/> instance containing the event data.</param>
        void OnShutdown(ShutdownEventArgs args);
    }

    public class ShutdownEventArgs : EventArgs
    {

    }
}
