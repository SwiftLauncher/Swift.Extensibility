using System.Collections.Generic;

namespace Swift.Extensibility.Input
{
    public interface IInput
    {
        /// <summary>
        /// Gets the complete string representation of this <see cref="IInput"/>.
        /// </summary>
        string Value { get; }

        /// <summary>
        /// Gets the <see cref="InputType"/> of this <see cref="IInput"/>.
        /// </summary>
        InputType Type { get; }

        /// <summary>
        /// Gets the Function parts (like note.remove: -> "note","remove") of this <see cref="IInput"/>, if this <see cref="IInput"/>'s Type is Function. Otherwise, this yields an empty collection.
        /// </summary>
        IEnumerable<string> FunctionParts { get;  }
    }

    public enum InputType
    {
        Function,
        General
    }
}
