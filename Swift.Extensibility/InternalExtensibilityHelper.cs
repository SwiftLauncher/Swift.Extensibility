using System.ComponentModel.Composition;
using Swift.Extensibility.Input.Functions;
using Swift.Extensibility.Services;

namespace Swift.Extensibility
{
    /// <summary>
    /// [FOR INTERNAL PURPOSES ONLY]
    /// </summary>
    public class InternalExtensibilityHelper : IInitializationAware
    {
        internal static IFunctionManager FunctionManager { get; private set; }

        /// <summary>
        /// Sets the function manager import.
        /// </summary>
        /// <value>
        /// The function manager import.
        /// </value>
        [Import]
        public IFunctionManager FunctionManagerImport
        {
            set
            {
                FunctionManager = value;
            }
        }

        /// <summary>
        /// Gets or sets the initialization priority.
        /// </summary>
        /// <value>
        /// The initialization priority.
        /// </value>
        public int InitializationPriority => int.MinValue;

        /// <summary>
        /// Raises the <see cref="E:Initialization" /> event.
        /// </summary>
        /// <param name="args">The <see cref="Swift.Extensibility.Services.InitializationEventArgs" /> instance containing the event data.</param>
        public void OnInitialization(InitializationEventArgs args) { }
    }
}
