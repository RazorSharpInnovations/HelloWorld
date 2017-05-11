using System;
using System.Configuration;
using RSI.HelloWorld.Common.Helpers.Interfaces;

namespace RSI.HelloWorld.Common.Helpers
{
    /// <summary>
    ///     ConfigurationHelper class.
    /// </summary>
    public class ConfigurationHelper : IConfigurationHelper
    {
        #region IConfigurationHelper Interface Implementations

        /// <summary>
        ///     Gets an app setting.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The value of the app setting key; otherwise an exception is thrown.</returns>
        public string GetAppSetting(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var appSettingValue = ConfigurationManager.AppSettings[key];

            if (appSettingValue == null)
            {
                throw new ConfigurationErrorsException($"Missing AppSetting parameter [{key}]");
            }

            return appSettingValue;
        }

        /// <summary>
        ///     Gets an app setting.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The value of the app setting key; otherwise null.</returns>
        public string TryGetAppSetting(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            string appSettingValue;
            try
            {
                appSettingValue = ConfigurationManager.AppSettings[key];
            }
            catch (Exception)
            {
                return null;
            }
            return appSettingValue;
        }

        #endregion
    }
}