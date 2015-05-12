using System;
using Swift.Toolkit;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Represents a setting that has an integer value. Can be clamped between min and max values.
    /// </summary>
    public sealed class IntegerSetting : BindableBase, ISetting<int>
    {
        private int _value;
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value != _value && value >= MinValue && value <= MaxValue)
                {
                    Set(ref _value, value);
                    if (ChangeCallback != null) ChangeCallback(value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        public int DefaultValue { get; private set; }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <value>
        /// The minimum value.
        /// </value>
        public int MinValue { get; private set; }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <value>
        /// The maximum value.
        /// </value>
        public int MaxValue { get; private set; }

        /// <summary>
        /// Gets the change callback.
        /// </summary>
        /// <value>
        /// The change callback.
        /// </value>
        public Action<int> ChangeCallback { get; private set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets or sets the tool tip. Can be null to hide tooltips.
        /// </summary>
        public string ToolTip { get; private set; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerSetting"/> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="changeCallback">The change callback.</param>
        /// <param name="value">The value.</param>
        /// <param name="tooltip">The tooltip.</param>
        /// <param name="description">The description.</param>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        public IntegerSetting(string displayName, int defaultValue, Action<int> changeCallback, int value = 0, string tooltip = "", string description = "", int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            DisplayName = displayName;
            Value = value;
            ChangeCallback = changeCallback;
            DefaultValue = defaultValue;
            ToolTip = tooltip;
            Description = description;
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
}
