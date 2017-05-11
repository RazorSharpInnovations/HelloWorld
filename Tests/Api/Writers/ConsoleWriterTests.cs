using System;
using System.IO;
using NUnit.Framework;
using RSI.HelloWorld.Api.Writers;
using RSI.HelloWorld.Common;
using RSI.HelloWorld.Common.Helpers;
using RSI.HelloWorld.Common.StructureMap;

namespace RSI.HelloWorld.Tests.Api.Writers
{
    [TestFixture]
    [Category("Writers")]
    public class ConsoleWriterTests
    {
        [SetUp]
        public void Init()
        {
            var standardOutput = new StreamWriter(Console.OpenStandardOutput()) {AutoFlush = true};

            Console.SetOut(standardOutput);
        }

        private static ConsoleWriter GetWriter()
        {
            return ObjectFactory.Container.GetInstance<ConsoleWriter>();
        }

        [Test]
        public void WriteValue_Can()
        {
            var configurationHelper = new ConfigurationHelper();

            var expectedOutputString =
                $"{configurationHelper.GetAppSetting(Constants.AppSettings.OutputStringKey)}{Environment.NewLine}";

            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                var consoleWriter = GetWriter();

                consoleWriter.WriteValue();

                Assert.AreEqual(expectedOutputString, stringWriter.ToString(),
                    $"Expected:{Environment.NewLine}{expectedOutputString}{Environment.NewLine}Received:{Environment.NewLine}{stringWriter}");
            }
        }

        [Test]
        public void WriteValue_Matches_Expected_OutputString()
        {
            var configurationHelper = new ConfigurationHelper();

            var expectedOutputString =
                $"{configurationHelper.GetAppSetting(Constants.AppSettings.OutputStringKey)}{Environment.NewLine}";

            var wrongOutputString =
                $"{configurationHelper.GetAppSetting(TestConstants.AppSettings.OutputStringWrongKey)}{Environment.NewLine}";

            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                var consoleWriter = GetWriter();

                consoleWriter.WriteValue();

                Assert.AreEqual(expectedOutputString, stringWriter.ToString(),
                    $"Expected:{Environment.NewLine}{expectedOutputString}{Environment.NewLine}Received:{Environment.NewLine}{stringWriter}");

                Assert.AreNotEqual(wrongOutputString, stringWriter.ToString(),
                    $"Expected Wrong:{Environment.NewLine}{wrongOutputString}{Environment.NewLine}Received:{Environment.NewLine}{stringWriter}");
            }
        }
    }
}