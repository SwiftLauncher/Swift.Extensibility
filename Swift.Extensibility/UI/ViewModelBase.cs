using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Base class for viewmodels in Swift.
    /// </summary>
    public class ViewModelBase : IViewModel, INotifyPropertyChanged
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
            var p = PropertyChanged;
            if (p != null)
                p(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sets the specified field, raising the <see cref="PropertyChanged"/> event if applicable.
        /// </summary>
        /// <typeparam name="T">The type of the value to set.</typeparam>
        /// <param name="field">The field.</param>
        /// <param name="value">The value.</param>
        /// <param name="propertyName">Name of the property that changed.</param>
        protected void Set<T>(ref T field, T value, [CallerMemberName]string propertyName = "")
        {
            if (!object.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(propertyName);
            }
        }
    }
}
