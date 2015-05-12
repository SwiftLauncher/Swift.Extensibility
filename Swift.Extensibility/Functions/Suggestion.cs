namespace Swift.Plugins.Functions
{
    public sealed class Suggestion
    {
        public string DisplayTitle { get; private set; }
        public string ReplacementString { get; private set; }
        public static Suggestion Create(string displayTitle, string replacementString)
        {
            // TODO check for unset parameters
            return new Suggestion() { DisplayTitle = displayTitle, ReplacementString = replacementString };
        }
    }
}
