using RSI.HelloWorld.Api.Writers.Interfaces;

namespace RSI.HelloWorld.Api.Factories.Interfaces
{
    /// <summary>
    ///     The interface for the WriterFactory class.
    /// </summary>
    public interface IWriterFactory
    {
        #region Public Members

        /// <summary>
        ///     Creates the writer.
        /// </summary>
        /// <returns>The writer that was created.</returns>
        IWriter CreateWriter();

        #endregion
    }
}