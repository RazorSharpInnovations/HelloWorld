namespace RSI.HelloWorld.Common.Helpers.Interfaces
{
    /// <summary>
    ///     Interface for the ConfigurationHelper class.
    /// </summary>
    public interface IConfigurationHelper
    {
        #region Public Members

        /// <summary>
        ///     Gets an app setting.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The value of the app setting key; otherwise an exception is thrown.</returns>
        string GetAppSetting(string key);

        /// <summary>
        ///     Gets an app setting.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The value of the app setting key; otherwise null.</returns>
        string TryGetAppSetting(string key);

        #endregion
    }
}