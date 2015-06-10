namespace Swift.Extensibility.Services.Hotkeys
{
    /// <summary>
    /// Contains HotkeyVisibilities.
    /// </summary>
    public enum HotkeyVisibility
    {
        /// <summary>
        /// If marked as public, a hotkey will raise the public OnHotkey event when it is pressed in addition to the callback delegate.
        /// </summary>
        Public,
        /// <summary>
        /// If marked as private, a hotkey will not raise the public OnHotkey event, but only call the callback delegate.
        /// </summary>
        Private
    }
}