﻿using System;

namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Interface for the UI Service component of Swift.
    /// </summary>
    public interface IUiService
    {
        /// <summary>
        /// Adds the resource dictionary loaded from the given Uri to the app-wide resources.
        /// </summary>
        /// <param name="resourceDictionaryUri">The resource.</param>
        void AddUiResource(Uri resourceDictionaryUri);

        /// <summary>
        /// Registers the menu item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The corresponding <see cref="RegisterMenuItemResult"/>.</returns>
        RegisterMenuItemResult RegisterMenuItem(MenuItem item);

        /// <summary>
        /// Navigates the specified viewmodel to the given target.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <param name="target">The target.</param>
        void Navigate(object viewModel, string target);

        /// <summary>
        /// Executes the given <see cref="Action"/> on the UI-Thread.
        /// </summary>
        /// <param name="callback">The <see cref="Action"/> to be executed on the UI-Thread.</param>
        void UiDispatch(Action callback);

        /// <summary>
        /// Executes the given <see cref="Func{TResult}" /> on the UI-Thread.
        /// </summary>
        /// <typeparam name="T">The return type of the function to be dispatched.</typeparam>
        /// <param name="callback">The <see cref="Func{TResult}" /> to be executed on the UI-Thread.</param>
        /// <returns></returns>
        T UiDispatch<T>(Func<T> callback);
    }
}
