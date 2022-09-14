// ***********************************************************************
// Assembly         : RecordingBot.Tests
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="ConsoleMainTest.cs" company="Recosenselabs.com">
//     Copyright �  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using NUnit.Framework;
using System;
using System.IO;

namespace RecordingBot.Tests.ConsoleTest
{
    /// <summary>
    /// Defines test class ConsoleMainTest.
    /// </summary>
    [TestFixture]
    public class ConsoleMainTest
    {
        /// <summary>
        /// The save
        /// </summary>
        private TextWriter _save;

        /// <summary>
        /// Setups the console test.
        /// </summary>
        [OneTimeSetUp]
        public void SetupConsoleTest()
        {
            _save = System.Console.Out;
        }

        /// <summary>
        /// Teardowns the console test.
        /// </summary>
        [OneTimeTearDown]
        public void TeardownConsoleTest()
        {
            System.Console.SetOut(_save);
        }


        /// <summary>
        /// Defines the test method TestVersion.
        /// </summary>
        [Test]
        public void TestVersion()
        {
            using (StringWriter sw = new StringWriter())
            {
                System.Console.SetOut(sw);

                Console.Program.Main(new string[] { "-v" });

                Version version;
                Version.TryParse(sw.ToString(), out version);

                Assert.IsNotNull(version);
            }
        }
    }
}
