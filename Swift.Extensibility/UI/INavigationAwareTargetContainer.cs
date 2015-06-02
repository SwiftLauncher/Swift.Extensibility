using System.ComponentModel.Composition;

namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Interface for Navigation-aware NavigationTargetContainers.
    /// </summary>
    [InheritedExport]
    public interface INavigationAwareTargetContainer
    {
        /// <summary>
        /// Gets called before an incoming navigation happens.
        /// </summary>
        /// <param name="viewModel">The viewmodel object.</param>
        /// <param name="target">The target that the viewmodel should be navigated to.</param>
        /// <returns>A <see cref="NavigationHandlerResult"/> value indicating how navigation should proceed.</returns>
        NavigationHandlerResult OnIncomingNavigation(object viewModel, string target);

        /// <summary>
        /// Gets called before an outgoing navigation happens.
        /// </summary>
        /// <param name="target">The target that the viewmodel should be navigated from.</param>
        /// <returns>A <see cref="NavigationHandlerResult"/> value indicating how navigation should proceed.</returns>
        NavigationHandlerResult OnOutgoingNavigation(string target);
    }
}
