using System;

namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Attribute to mark navigation targets.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class NavigationTargetAttribute : Attribute
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationTargetAttribute"/> class.
        /// </summary>
        /// <param name="name">The name of this target. Has to be unique.</param>
        public NavigationTargetAttribute(string name)
        {
            Name = name;
        }
    }
}