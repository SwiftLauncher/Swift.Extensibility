using System;

namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Attribute to mark navigation targets.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class NavigationTargetAttribute : Attribute
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; }

        /// <summary>
        /// The navigation Handler.
        /// </summary>
        public NavigationHandler NavigationHandler { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationTargetAttribute"/> class.
        /// </summary>
        /// <param name="name">The name of this target. Has to be unique.</param>
        /// <param name="navigationHandler">The optional navigation handler.</param>
        public NavigationTargetAttribute(string name, NavigationHandler navigationHandler = null)
        {
            Name = name;
            NavigationHandler = navigationHandler;
        }
    }

    /// <summary>
    /// Handler for navigation events.
    /// </summary>
    /// <param name="viewModel">The viewmodel that gets navigated.</param>
    /// <param name="navigationTarget">The navigation target.</param>
    /// <param name="mode">The navigation mode.</param>
    public delegate NavigationHandlerResult NavigationHandler(object viewModel, string navigationTarget, NavigationMode mode);

    /// <summary>
    /// Navigation modes.
    /// </summary>
    public enum NavigationMode
    {
        /// <summary>
        /// Indicates that the current navigation navigates TO the target.
        /// </summary>
        Incoming,
        /// <summary>
        /// Indicates that the current navigation navigates FROM the target.
        /// </summary>
        Outgoing
    }

    /// <summary>
    /// Contains results for navigation handlers.
    /// </summary>
    public enum NavigationHandlerResult
    {
        /// <summary>
        /// Indicates that the navigation request should not be processed further and has not been handled by the handler.
        /// </summary>
        CancelNavigation,
        /// <summary>
        /// Indicates that the navigation framework can continue processing the navigation request.
        /// </summary>
        ContinueNavigation,
        /// <summary>
        /// Indicates that the handler has already handled the navigation request.
        /// </summary>
        NavigationHandled
    }
}