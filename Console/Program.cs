using System;
using RSI.HelloWorld.Api.Factories;
using RSI.HelloWorld.Api.Factories.Interfaces;
using RSI.HelloWorld.Common.StructureMap;

namespace RSI.HelloWorld.Console
{
    /// <summary>
    ///     The Program class.
    /// </summary>
    public class Program
    {
        #region Static Public Members

        /// <summary>
        ///     Main program entry point.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            ObjectFactory.Initialize();

            DisplayOutputString(ObjectFactory.Container.GetInstance<ConsoleWriterFactory>());
        }

        #endregion

        #region Static Private Members

        private static void DisplayOutputString(IWriterFactory writerFactory)
        {
            if (writerFactory == null)
            {
                throw new ArgumentNullException(nameof(writerFactory));
            }

            var writer = writerFactory.CreateWriter();

            writer.WriteValue();
        }

        #endregion
    }
}