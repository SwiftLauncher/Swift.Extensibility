using System;

namespace Swift.Extensibility.Services.Hotkeys
{
    /// <summary>
    /// EventArgs for hotkey events.
    /// </summary>
    public sealed class HotkeyEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the name of the hotkey that was pressed.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HotkeyEventArgs"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public HotkeyEventArgs(string name)
        {
            Name = name;
        }
    }
}