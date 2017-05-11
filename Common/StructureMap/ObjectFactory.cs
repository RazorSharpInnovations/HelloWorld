using System;
using StructureMap;

namespace RSI.HelloWorld.Common.StructureMap
{
    /// <summary>
    ///     The ObjectFactory class.
    /// </summary>
    public static class ObjectFactory
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the container.
        /// </summary>
        public static Container Container { get; set; }

        #endregion

        #region Static Public Members

        /// <summary>
        ///     Initializes the ObjectFactory.
        /// </summary>
        public static void Initialize()
        {
            Container = new Container(container => container.Scan(scan =>
            {
                scan.AssembliesFromApplicationBaseDirectory(
                    a =>
                        a.GetName()
                            .Name.StartsWith("RSI.HelloWorld",
                                StringComparison.InvariantCultureIgnoreCase));
                scan.WithDefaultConventions();
            }));
        }

        #endregion
    }
}