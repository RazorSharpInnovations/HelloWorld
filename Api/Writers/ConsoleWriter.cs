using System;
using RSI.HelloWorld.Api.Writers.Interfaces;
using RSI.HelloWorld.Common;
using RSI.HelloWorld.Common.Helpers;

namespace RSI.HelloWorld.Api.Writers
{
    /// <summary>
    ///     The ConsoleWriter class.
    /// </summary>
    public class ConsoleWriter : IWriter
    {
        #region IWriter Interface Implementations

        /// <summary>
        ///     Writes a value.
        /// </summary>
        public void WriteValue()
        {
            var configurationHelper = new ConfigurationHelper();

            try
            {
                var outputString = configurationHelper.GetAppSetting(Constants.AppSettings.OutputStringKey);

                Console.Out.WriteLine(outputString);
            }
            catch (Exception exception)
            {
                Console.Out.WriteLine($"Unable to get output string. Error was: {exception.Message}");
            }
        }

        #endregion
    }
}