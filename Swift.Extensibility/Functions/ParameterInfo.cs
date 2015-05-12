using System;

namespace Swift.Extensibility.Functions
{
    /// <summary>
    /// Represents a parameter definition in functions.
    /// </summary>
    public sealed class ParameterInfo
    {
        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string DisplayName { get; private set; }
        /// <summary>
        /// Gets the short name.
        /// </summary>
        /// <value>
        /// The short name.
        /// </value>
        public string ShortName { get; private set; }
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public Type Type { get; private set; }
        /// <summary>
        /// Gets a value indicating whether this instance is optional.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is optional; otherwise, <c>false</c>.
        /// </value>
        public bool IsOptional { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterInfo"/> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="type">The type.</param>
        /// <param name="shortName">The short name.</param>
        public ParameterInfo(string displayName, Type type, string shortName = null, bool isOptional = false)
        {
            DisplayName = displayName;
            Type = type;
            ShortName = shortName;
            IsOptional = isOptional;
        }
    }
}
