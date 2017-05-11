using RSI.HelloWorld.Api.Factories.Interfaces;
using RSI.HelloWorld.Api.Writers;
using RSI.HelloWorld.Api.Writers.Interfaces;

namespace RSI.HelloWorld.Api.Factories
{
    /// <summary>
    ///     The ConsoleWriterFactory class.
    /// </summary>
    public class ConsoleWriterFactory : IWriterFactory
    {
        #region IWriterFactory Interface Implementations

        /// <summary>
        ///     Creates the writer.
        /// </summary>
        /// <returns>The writer that was created.</returns>
        public IWriter CreateWriter()
        {
            return new ConsoleWriter();
        }

        #endregion
    }
}