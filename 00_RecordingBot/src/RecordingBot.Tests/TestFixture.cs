// ***********************************************************************
// Assembly         : RecordingBot.Tests
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="TestFixture.cs" company="Recosenselabs.com">
//     Copyright �  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using NUnit.Framework;
using System.IO;

namespace RecordingBot.Tests
{
    /// <summary>
    /// Class TestFixture.
    /// </summary>
    [SetUpFixture]
    public class TestFixture
    {
        /// <summary>
        /// Changes the current directory.
        /// </summary>
        [OneTimeSetUp]
        public void ChangeCurrentDirectory()
        {
            var dir = Path.GetDirectoryName(typeof(TestFixture).Assembly.Location);
            Directory.SetCurrentDirectory(dir);
        }
    }
}
