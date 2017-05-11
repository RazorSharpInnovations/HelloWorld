using System;
using System.Runtime.Serialization;

namespace RSI.HelloWorld.Common
{
    /// <summary>
    ///     The ConfigurationErrorsException class.
    /// </summary>
    [Serializable]
    public class ConfigurationErrorsException : Exception
    {
        #region Public Constructors

        /// <summary>
        ///     The base constructor.
        /// </summary>
        public ConfigurationErrorsException()
        {
        }

        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="message">The error message.</param>
        public ConfigurationErrorsException(string message) : base(message)
        {
        }

        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="message"> The error message. </param>
        /// <param name="exception"> The exception. </param>
        public ConfigurationErrorsException(string message, Exception exception) : base(message, exception)
        {
        }

        #endregion

        #region Protected Constructors

        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="serializationInfo"> The serialization info. </param>
        /// <param name="streamingContext"> The streaming context. </param>
        protected ConfigurationErrorsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }

        #endregion
    }
}