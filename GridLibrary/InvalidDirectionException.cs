using System;

namespace GridLibrary
{
    /// <summary>
    /// The Exception that is thrown when an invalid <see cref="Direction"/> is used.
    /// </summary>
    [Serializable]
    public class InvalidDirectionException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidDirectionException"/> class.
        /// </summary>
        public InvalidDirectionException() : base() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidDirectionException"/> class with a specified error message.
        /// </summary>
        /// <param name="message"></param>
        public InvalidDirectionException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidDirectionException"/> class with a specified error message and inner exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public InvalidDirectionException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Intializes a new instance of the <see cref="InvalidDirectionException"/> class with serialization info and context.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public InvalidDirectionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}