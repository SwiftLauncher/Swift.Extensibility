namespace Swift.Extensibility.Services.Profile
{
    public sealed class UserProfile : IUserProfile
    {
        public string KeyMaterial
        {
            get;
            private set;
        }

        public string UserName
        {
            get;
            private set;
        }

        public UserProfile(string userName, string keyMaterial)
        {
            UserName = userName;
            KeyMaterial = keyMaterial;
        }
    }
}
