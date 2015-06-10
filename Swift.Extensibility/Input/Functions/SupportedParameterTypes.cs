using System;
using System.Linq;

namespace Swift.Extensibility.Input.Functions
{
    /// <summary>
    /// Contains supported parameter types of Swift functions.
    /// </summary>
    public static class SupportedParameterTypes
    {
        /// <summary>
        /// The <see cref="Int32"/> type.
        /// </summary>
        public static readonly Type Int32 = typeof(int);

        /// <summary>
        /// The <see cref="Float"/> type.
        /// </summary>
        public static readonly Type Float = typeof(float);

        /// <summary>
        /// The <see cref="String"/> type.
        /// </summary>
        public static readonly Type String = typeof(string);

        /// <summary>
        /// The <see cref="Input"/> type.
        /// </summary>
        public static readonly Type Input = typeof(Input);

        /// <summary>
        /// The <see cref="ISwiftFunctionCallContext"/> type.
        /// </summary>
        public static readonly Type CallContext = typeof(ISwiftFunctionCallContext);

        /// <summary>
        /// A list of all supported types.
        /// </summary>
        public static readonly Type[] AllTypes = { typeof(int), typeof(float), typeof(string), typeof(Input), typeof(ISwiftFunctionCallContext) };

        /// <summary>
        /// Gets a value indicating whether the specified type if supported as a Swift function parameter.
        /// </summary>
        /// <typeparam name="T">The parameter type to check for.</typeparam>
        /// <returns>True, if the specified type is supported. False otherwise.</returns>
        public static bool IsSupported<T>() => AllTypes.Contains(typeof(T));

        /// <summary>
        /// Gets a value indicating whether the specified type if supported as a Swift function parameter.
        /// </summary>
        /// <param name="type">The parameter type to check for.</param>
        /// <returns>True, if the specified type is supported. False otherwise.</returns>
        public static bool IsSupported(Type type) => AllTypes.Contains(type);
    }
}
