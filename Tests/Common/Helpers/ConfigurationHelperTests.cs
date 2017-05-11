using System;
using NUnit.Framework;
using RSI.HelloWorld.Common;
using RSI.HelloWorld.Common.Helpers;
using RSI.HelloWorld.Common.Helpers.Interfaces;

namespace RSI.HelloWorld.Tests.Common.Helpers
{
    [TestFixture]
    [Category("Helpers")]
    public class ConfigurationHelperTests
    {
        private static IConfigurationHelper GetHelper()
        {
            return new ConfigurationHelper();
        }

        [Test]
        public void GetAppSetting_Can()
        {
            Assert.AreEqual(TestConstants.AppSettings.ValidValue, GetHelper().GetAppSetting(TestConstants.AppSettings.ValidKey));
        }

        [Test]
        public void GetAppSetting_Returns_Empty_String_When_Parameter_Empty()
        {
            Assert.AreEqual(string.Empty, GetHelper().GetAppSetting(TestConstants.AppSettings.EmptyKey));
        }

        [Test]
        public void GetAppSetting_Throws_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => GetHelper().GetAppSetting(null));
        }

        [Test]
        public void GetAppSetting_Throws_ConfigurationErrorsException_For_Missing_Parameter()
        {
            Assert.Throws<ConfigurationErrorsException>(() => GetHelper().GetAppSetting(TestConstants.AppSettings.DoesNotExistKey));
        }

        [Test]
        public void TryGetAppSetting_Can()
        {
            Assert.AreEqual(TestConstants.AppSettings.ValidValue, GetHelper().TryGetAppSetting(TestConstants.AppSettings.ValidKey));
        }

        [Test]
        public void TryGetAppSetting_Returns_Null_String_When_Parameter_Empty()
        {
            Assert.AreEqual(null, GetHelper().TryGetAppSetting(string.Empty));
        }

        [Test]
        public void TryGetAppSetting_Returns_Null_When_Parameter_Missing()
        {
            Assert.AreEqual(null, GetHelper().TryGetAppSetting(TestConstants.AppSettings.DoesNotExistKey));
        }

        [Test]
        public void TryGetAppSetting_Throws_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => GetHelper().TryGetAppSetting(null));
        }
    }
}