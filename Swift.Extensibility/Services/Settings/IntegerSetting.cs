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
                    ChangeCallback?.Invoke(value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        public int DefaultValue { get; set; }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <value>
        /// The minimum value.
        /// </value>
        public int MinValue { get; set; } = int.MinValue;

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <value>
        /// The maximum value.
        /// </value>
        public int MaxValue { get; set; } = int.MaxValue;

        /// <summary>
        /// Gets the change callback.
        /// </summary>
        /// <value>
        /// The change callback.
        /// </value>
        public Action<int> ChangeCallback { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the tool tip. Can be null to hide tooltips.
        /// </summary>
        public string ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use slider view.
        /// </summary>
        public bool UseSliderView { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerSetting"/> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="changeCallback">The change callback.</param>
        public IntegerSetting(string displayName, int defaultValue, Action<int> changeCallback)
        {
            DisplayName = displayName;
            ChangeCallback = changeCallback;
            DefaultValue = defaultValue;
        }
    }
}
