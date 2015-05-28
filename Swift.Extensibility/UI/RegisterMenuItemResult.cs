namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Results of menu item registration.
    /// </summary>
    public enum RegisterMenuItemResult
    {
        /// <summary>
        /// The menu item was successfully registered.
        /// </summary>
        Successful,
        /// <summary>
        /// The menu item already existed.
        /// </summary>
        AlreadyExisting,
        /// <summary>
        /// Failed to register the menu item.
        /// </summary>
        Failed
    }
}