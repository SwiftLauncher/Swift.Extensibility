using System;
using Swift.Extensibility.Input.Functions;

namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Represents a MenuItem in one of Swift's menus.
    /// </summary>
    public sealed class MenuItem
    {
        /// <summary>
        /// Gets the text.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Gets the associated function name.
        /// </summary>
        public string Function { get; }

        /// <summary>
        /// Gets the function input.
        /// </summary>
        /// <value>
        /// The function input.
        /// </value>
        public Input.Input FunctionInput { get; }

        /// <summary>
        /// Gets the icon.
        /// </summary>
        public Uri IconSource { get; }

        /// <summary>
        /// Gets the target menu.
        /// </summary>
        public MenuTarget TargetMenu { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem" /> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="function">The name of the associated function.</param>
        /// <param name="targetMenu">The target Menu.</param>
        /// <param name="iconSource">The icon.</param>
        /// <param name="functionInput">The function input.</param>
        public MenuItem(string text, string function, MenuTarget targetMenu, Uri iconSource = null, Input.Input functionInput = null)
        {
            Text = text;
            Function = function;
            TargetMenu = targetMenu;
            IconSource = iconSource;
            FunctionInput = functionInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="function">The function.</param>
        /// <param name="targetMenu">The target menu.</param>
        /// <param name="iconSource">The icon source.</param>
        /// <param name="functionInput">The function input.</param>
        public MenuItem(string text, FunctionInfo function, MenuTarget targetMenu, Uri iconSource = null, Input.Input functionInput = null)
        {
            Text = text;
            Function = function.FullName;
            TargetMenu = targetMenu;
            IconSource = iconSource;
            FunctionInput = functionInput;
        }
    }
}
