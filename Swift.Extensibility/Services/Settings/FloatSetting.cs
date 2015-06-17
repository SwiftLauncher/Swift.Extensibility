using System;
using Swift.Toolkit;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Represents a setting that has a float value. Can be clamped between min and max values.
    /// </summary>
    public sealed class FloatSetting : BindableBase, ISetting<float>
    {
        private float _value;
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public float Value
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
        public float DefaultValue { get; set; }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <value>
        /// The minimum value.
        /// </value>
        public float MinValue { get; set; } = float.MinValue;

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <value>
        /// The maximum value.
        /// </value>
        public float MaxValue { get; set; } = float.MaxValue;

        /// <summary>
        /// Gets the change callback.
        /// </summary>
        /// <value>
        /// The change callback.
        /// </value>
        public Action<float> ChangeCallback { get; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; }

        /// <summary>
        /// Gets or sets the tool tip. Can be null to hide tooltips.
        /// </summary>
        public string ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatSetting" /> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="value">The value.</param>
        /// <param name="changeCallback">The change callback.</param>
        public FloatSetting(string displayName, float value, Action<float> changeCallback)
        {
            DisplayName = displayName;
            Value = value;
            ChangeCallback = changeCallback;
        }
    }
}
