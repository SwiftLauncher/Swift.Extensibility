using System;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Swift.Extensibility.Services.Profile
{
    /// <summary>
    /// Plugins can implement this interface to enable the user to log in to Swift using their service.
    /// </summary>
    [InheritedExport]
    public interface IProfileProvider : ISwiftExtender
    {
        /// <summary>
        /// Profile providers have to fire this event when the login attempt has been completed.
        /// </summary>
        event Action<bool> LoginCompleted;

        /// <summary>
        /// The name of this Login-Service.
        /// </summary>
        string ServiceName { get; }
        /// <summary>
        /// [optional] An icon that represents this Service.
        /// </summary>
        BitmapImage Icon { get; }
        /// <summary>
        /// A short description of this Login-Service.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// The custom Login-UI.
        /// </summary>
        FrameworkElement LoginView { get; }
        /// <summary>
        /// Status of Login after login attempt.
        /// </summary>
        bool IsLoggedIn { get; }
        /// <summary>
        /// The <see cref="IUserProfile"/> to be returned after successful Login. Required by Swift for further user identification and encryption.
        /// </summary>
        IUserProfile UserProfile { get; }

        /// <summary>
        /// This will be called when the provider has been chosen and login should be performed. Use this only for preparation and automatic login. This will not run on the GUI Thread.
        /// </summary>
        void LoginAsync();
    }
}
