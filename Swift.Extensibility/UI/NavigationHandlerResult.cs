namespace Swift.Extensibility.UI
{
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