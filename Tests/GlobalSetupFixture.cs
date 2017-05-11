using NUnit.Framework;
using RSI.HelloWorld.Common.StructureMap;

namespace RSI.HelloWorld.Tests
{
    [SetUpFixture]
    public class GlobalSetupFixture
    {
        #region Public Members

        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            ObjectFactory.Initialize();
        }

        #endregion
    }
}