using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Interface for the UI Service component of Swift.
    /// </summary>
    public interface IUIService
    {
        /// <summary>
        /// Adds the resource dictionary loaded from the given Uri to the app-wide resources.
        /// </summary>
        /// <param name="resourceDictionaryUri">The resource.</param>
        void AddUIResource(Uri resourceDictionaryUri);

        /// <summary>
        /// Registers the menu item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The corresponding <see cref="RegisterMenuItemResult"/>.</returns>
        RegisterMenuItemResult RegisterMenuItem(MenuItem item);

        /// <summary>
        /// Navigates the specified view to the given viewmodel.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <param name="target">The target.</param>
        void Navigate(IViewModel viewModel, string target);

        /// <summary>
        /// Executes the given <see cref="Action"/> on the UI-Thread.
        /// </summary>
        /// <param name="callback">The <see cref="Action"/> to be executed on the UI-Thread.</param>
        void UIDispatch(Action callback);

        /// <summary>
        /// Executes the given <see cref="Func" /> on the UI-Thread.
        /// </summary>
        /// <typeparam name="T">The return type of the function to be dispatched.</typeparam>
        /// <param name="callback">The <see cref="Func" /> to be executed on the UI-Thread.</param>
        /// <returns></returns>
        T UIDispatch<T>(Func<T> callback);
    }

    public enum RegisterMenuItemResult
    {
        Successful,
        AlreadyExisting,
        Failed
    }

    /// <summary>
    /// Contains constants for navigation targets.
    /// </summary>
    public static class NavigationTargets
    {
        /// <summary>
        /// The center view
        /// </summary>
        public const string CenterView = "Shell.CenterView";
    }
}
