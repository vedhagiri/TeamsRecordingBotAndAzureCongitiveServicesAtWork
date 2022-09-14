// ***********************************************************************
// Assembly         : RecordingBot.Tests
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="BotHostTest.cs" company="Recosenselabs.com">
//     Copyright �  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using NUnit.Framework;

namespace RecordingBot.Tests.BotTests
{
    /// <summary>
    /// Defines test class BotHostTest.
    /// Implements the <see cref="RecordingBot.Tests.TestBase" />
    /// </summary>
    /// <seealso cref="RecordingBot.Tests.TestBase" />
    [TestFixture]
    [Ignore("Ignoring test as it's used to development and should be ran on local machine.")]
    public class BotHostTest : TestBase
    {
        /// <summary>
        /// Defines the test method FirstUpBot.
        /// </summary>
        [Test]
        public void FirstUpBot()
        {
            this.StartServer();
            System.Threading.Thread.Sleep(-1);

        }
    }
}
