using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Base class for viewmodels in Swift.
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">Name of the property that changed.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sets the specified field, raising the <see cref="PropertyChanged"/> event if applicable.
        /// </summary>
        /// <typeparam name="T">The type of the value to set.</typeparam>
        /// <param name="field">The field.</param>
        /// <param name="value">The value.</param>
        /// <param name="propertyName">Name of the property that changed.</param>
        /// <returns>True, if the field was set. False otherwise.</returns>
        [SuppressMessage("ReSharper", "ExplicitCallerInfoArgument")]
        protected bool Set<T>(ref T field, T value, [CallerMemberName]string propertyName = "")
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
