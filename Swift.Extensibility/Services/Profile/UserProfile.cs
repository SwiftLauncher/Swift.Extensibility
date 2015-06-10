namespace Swift.Extensibility.Services.Profile
{
    /// <summary>
    /// Represents a user profile.
    /// </summary>
    public sealed class UserProfile
    {
        /// <summary>
        /// The key material for cryptographic applications.
        /// </summary>
        public byte[] KeyMaterial { get; }

        /// <summary>
        /// The username.
        /// </summary>
        public string UserName { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="UserProfile"/> class.
        /// </summary>
        /// <param name="userName">The username.</param>
        /// <param name="keyMaterial">The key material for cryptographic applications.</param>
        public UserProfile(string userName, byte[] keyMaterial)
        {
            UserName = userName;
            KeyMaterial = keyMaterial;
        }
    }
}
