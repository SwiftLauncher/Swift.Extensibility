using System;
using System.Collections.Generic;

namespace Swift.Extensibility.Services.Settings
{
    public interface ISettingsStore
    {
        /// <summary>
        /// The storable types.
        /// </summary>
        IEnumerable<Type> StorableTypes { get; }

        /// <summary>
        /// Retrieves the value of the given type with the specified key.
        /// </summary>
        /// <typeparam name="T">The type of the value of the setting.</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>
        /// The value of the setting as T.
        /// </returns>
        T Retrieve<T>(string key, T defaultValue = default(T));

        /// <summary>
        /// Stores the specified key.
        /// </summary>
        /// <typeparam name="T">The type of the value of the setting.</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        void Store<T>(string key, T value);

        /// <summary>
        /// Checks wether this <see cref="ISettingsStore"/> contains an entry with the given Key.
        /// </summary>
        /// <param name="key">The key to look for.</param>
        /// <returns>True, if this <see cref="ISettingsStore"/> contains an entry with the given key, false otherwise.</returns>
        bool ContainsKey(string key);

        /// <summary>
        /// Checks wether this <see cref="ISettingsStore"/> contains at least one entry with the given Value.
        /// </summary>
        /// <param name="value">The value to look for.</param>
        /// <returns>True, if this <see cref="ISettingsStore"/> contains an entry with the given value, false otherwise.</returns>
        bool ContainsValue(object value);

        /// <summary>
        /// Deletes the entry with the given Key from this <see cref="ISettingsStore"/>.
        /// </summary>
        /// <param name="key">The key to identify the entry.</param>
        /// <returns>True, if the entry has been successfully deleted. False, if no entry with the given key could be found.</returns>
        bool DeleteEntry(string key);

        /// <summary>
        /// Occurs when an entry changed.
        /// </summary>
        event SettingsStoreEntryChangedEventHandler EntryChanged;
    }

    public delegate void SettingsStoreEntryChangedEventHandler(object sender, SettingsStoreEntryChangedEventArgs args);

    /// <summary>
    /// EventArgs for the SettingsStoreEntryChanged event.
    /// </summary>
    public class SettingsStoreEntryChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the key.
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        public string Key { get; private set; }

        /// <summary>
        /// Gets the old value.
        /// </summary>
        /// <value>
        /// The old value.
        /// </value>
        public object OldValue { get; private set; }

        /// <summary>
        /// Gets the new value.
        /// </summary>
        /// <value>
        /// The new value.
        /// </value>
        public object NewValue { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsStoreEntryChangedEventArgs"/> class.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="oldValue">The old value.</param>
        /// <param name="newValue">The new value.</param>
        public SettingsStoreEntryChangedEventArgs(string key, object oldValue, object newValue)
        {
            Key = key;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
