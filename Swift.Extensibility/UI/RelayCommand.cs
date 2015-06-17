using System;
using System.Windows.Input;

namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Represents an <see cref="ICommand"/> implemented with delegates.
    /// </summary>
    public class RelayCommand : ICommand
    {
        private readonly Action _executeDelegate;
        private readonly Func<bool> _canExecuteDelegate;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="executeDelegate">The execute delegate.</param>
        public RelayCommand(Action executeDelegate) : this(executeDelegate, () => true)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="executeDelegate">The execute delegate.</param>
        /// <param name="canExecuteDelegate">The can execute delegate.</param>
        public RelayCommand(Action executeDelegate, Func<bool> canExecuteDelegate)
        {
            _executeDelegate = executeDelegate;
            _canExecuteDelegate = canExecuteDelegate;
        }

        /// <summary>
        /// Determines whether this instance can execute the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => _canExecuteDelegate();

        /// <summary>
        /// Executes the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        public void Execute(object parameter)
        {
            _executeDelegate();
        }

        /// <summary>
        /// Raises the can execute changed.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Occurs when [can execute changed].
        /// </summary>
        public event EventHandler CanExecuteChanged;
    }
}
