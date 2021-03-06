﻿using System;
using Swift.Toolkit;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Base class for settings of specific types.
    /// </summary>
    /// <typeparam name="T">The setting type.</typeparam>
    public abstract class Setting<T> : BindableBase, ISetting<T>
    {
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the tool tip. Can be null to hide tooltips.
        /// </summary>
        public string ToolTip { get; set; } = "";

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        public string Description { get; set; } = "";

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
                if (!Equals(_value, value))
                {
                    Set(ref _value, value);
                    ChangeCallback?.Invoke(value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        public T DefaultValue { get; set; }

        /// <summary>
        /// Gets the change callback.
        /// </summary>
        /// <value>
        /// The change callback.
        /// </value>
        public Action<T> ChangeCallback { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Setting{T}" /> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="value">The value.</param>
        /// <param name="changeCallback">The change callback.</param>
        protected Setting(string displayName, T value, Action<T> changeCallback)
        {
            DisplayName = displayName;
            Value = value;
            ChangeCallback = changeCallback;
        }
    }
}
