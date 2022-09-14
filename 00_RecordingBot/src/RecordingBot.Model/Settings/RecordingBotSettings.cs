// ***********************************************************************
// Assembly         : RecordingBot.Model
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="RecordingBotSettings.cs" company="Recosenselabs.com">
//     Copyright �  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace RecordingBot.Model.Settings
{
    /// <summary>
    /// Class RecordingBotSettings.
    /// </summary>
    public class RecordingBotSettings
    {
        /// <summary>
        /// Gets or sets the service point manager default connection limit.
        /// </summary>
        /// <value>The service point manager default connection limit.</value>
        public int ServicePointManagerDefaultConnectionLimit { get; set; } = 12;
    }
}
