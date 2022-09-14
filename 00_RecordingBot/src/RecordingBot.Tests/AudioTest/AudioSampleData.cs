// ***********************************************************************
// Assembly         : RecordingBot.Tests
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="AudioSampleData.cs" company="Recosenselabs.com">
//     Copyright �  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using NUnit.Framework;
using RecordingBot.Model.Constants;
using System.IO;

namespace RecordingBot.Tests.AudioTest
{
    /// <summary>
    /// Defines test class AudioSampleData.
    /// </summary>
    [TestFixture]
    public class AudioSampleData
    {
        /// <summary>
        /// The path
        /// </summary>
        private static string path = Path.Combine(Path.GetTempPath(), BotConstants.DefaultOutputFolder, "test", "audio");

        /// <summary>
        /// Tests the clean.
        /// </summary>
        [TearDown]
        public void testClean()
        {
            Directory.Delete(path, true);
        }

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [SetUp]
        public void testInit()
        {
            Directory.CreateDirectory(path);
        }
    }
}
