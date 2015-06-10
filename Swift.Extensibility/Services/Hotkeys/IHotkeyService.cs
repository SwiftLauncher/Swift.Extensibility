using System;
using System.Windows.Input;

namespace Swift.Extensibility.Services.Hotkeys
{
    /// <summary>
    /// Allows registering application- and system-wide hotkeys.
    /// </summary>
    public interface IHotkeyService
    {
        /// <summary>
        /// Determines whether a hotkey the specified name is registered.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>True, if a hotkey with the given name is registered. False otherwise.</returns>
        bool IsRegistered(string name);

        /// <summary>
        /// Determines whether a hotkey with the specified key and modifiers is registered.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="modifiers">The modifiers.</param>
        /// <returns>True, if a hotkey with the given key and modifiers is registered. False otherwise.</returns>
        bool IsRegistered(Key key, ModifierKeys modifiers);

        /// <summary>
        /// Registers the hotkey. Only possible if no other hotkey with the same name or hotkey combination is already registered.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="key">The key.</param>
        /// <param name="modifiers">The modifiers.</param>
        /// <param name="mode">The mode.</param>
        /// <param name="visibility">The visibility.</param>
        /// <param name="callback">The callback.</param>
        /// <returns>
        /// An IDIsposable that will unregister the hotkey when disposed.
        /// </returns>
        IDisposable RegisterHotkey(string name, Key key, ModifierKeys modifiers, HotkeyMode mode, HotkeyVisibility visibility, Action<HotkeyEventArgs> callback);

        /// <summary>
        /// Occurs whenever a public hotkey is pressed.
        /// </summary>
        event HotkeyEventHandler OnHotkey;
    }

    /// <summary>
    /// Event handler for the OnHotkey event.
    /// </summary>
    /// <param name="args">The <see cref="HotkeyEventArgs"/> instance containing the event data.</param>
    public delegate void HotkeyEventHandler(HotkeyEventArgs args);
}
