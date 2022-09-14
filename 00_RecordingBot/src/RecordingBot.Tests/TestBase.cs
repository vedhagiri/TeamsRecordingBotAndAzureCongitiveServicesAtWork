// ***********************************************************************
// Assembly         : RecordingBot.Tests
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="TestBase.cs" company="Recosenselabs.com">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using RecordingBot.Services.ServiceSetup;

namespace RecordingBot.Tests
{
    /// <summary>
    /// Class TestBase.
    /// Implements the <see cref="RecordingBot.Services.ServiceSetup.AppHost" />
    /// </summary>
    /// <seealso cref="RecordingBot.Services.ServiceSetup.AppHost" />
    public class TestBase : AppHost
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestBase" /> class.

        /// </summary>
        public TestBase()
        {
            Boot();
        }
    }
}
