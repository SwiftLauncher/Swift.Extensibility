using System;
using Swift.Toolkit;

namespace Swift.Extensibility.Services.Settings
{
    public interface ISetting
    {
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Gets or sets the tool tip. Can be null to hide tooltips.
        /// </summary>
        string ToolTip { get; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        string Description { get; }
    }

    public interface ISetting<T> : ISetting
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        T Value { get; set; }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        T DefaultValue { get; }

        /// <summary>
        /// Gets the change callback.
        /// </summary>
        /// <value>
        /// The change callback.
        /// </value>
        Action<T> ChangeCallback { get; }
    }

    public abstract class Setting<T> : BindableBase, ISetting<T>
    {
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; protected set; }

        /// <summary>
        /// Gets or sets the tool tip. Can be null to hide tooltips.
        /// </summary>
        public string ToolTip { get; protected set; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        public string Description { get; protected set; }

        private T _value;
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (!Object.Equals(_value, value))
                {
                    Set(ref _value, value);
                    if (ChangeCallback != null) ChangeCallback(value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        public T DefaultValue { get; protected set; }

        /// <summary>
        /// Gets the change callback.
        /// </summary>
        /// <value>
        /// The change callback.
        /// </value>
        /// <exception cref="NotImplementedException"></exception>
        public Action<T> ChangeCallback { get; protected set; }
    }
}
