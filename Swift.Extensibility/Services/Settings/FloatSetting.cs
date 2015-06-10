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
        public float DefaultValue { get; }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <value>
        /// The minimum value.
        /// </value>
        public float MinValue { get; }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <value>
        /// The maximum value.
        /// </value>
        public float MaxValue { get; }

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
        public string ToolTip { get; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatSetting"/> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="changeCallback">The change callback.</param>
        /// <param name="value">The value.</param>
        /// <param name="tooltip">The tooltip.</param>
        /// <param name="description">The description.</param>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        public FloatSetting(string displayName, float defaultValue, Action<float> changeCallback, float value = 0, string tooltip = "", string description = "", float minValue = float.MinValue, float maxValue = float.MaxValue)
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
