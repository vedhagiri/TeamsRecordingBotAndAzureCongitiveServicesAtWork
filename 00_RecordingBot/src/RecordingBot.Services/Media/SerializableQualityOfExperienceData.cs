﻿// ***********************************************************************
// Assembly         : RecordingBot.Services
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 09-07-2022
// ***********************************************************************
// <copyright file="SerializableQualityOfExperienceData.cs" company="Recosenselabs.com">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.Skype.Bots.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingBot.Services.Media
{
    /// <summary>
    /// Class SerializableAudioQualityOfExperienceData.
    /// </summary>
    public class SerializableAudioQualityOfExperienceData
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public string Id;
        /// <summary>
        /// The average in bound network jitter
        /// </summary>
        public long AverageInBoundNetworkJitter;
        /// <summary>
        /// The maximum in bound network jitter
        /// </summary>
        public long MaximumInBoundNetworkJitter;
        /// <summary>
        /// The total media duration
        /// </summary>
        public long TotalMediaDuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableAudioQualityOfExperienceData" /> class.

        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="aQoE">a qo e.</param>
        public SerializableAudioQualityOfExperienceData(string Id, AudioQualityOfExperienceData aQoE)
        {
            this.Id = Id;
            AverageInBoundNetworkJitter = aQoE.AudioMetrics.AverageInboundNetworkJitter.Ticks;
            MaximumInBoundNetworkJitter = aQoE.AudioMetrics.MaximumInboundNetworkJitter.Ticks;
            TotalMediaDuration = aQoE.TotalMediaDuration.Ticks;
        }
    }
}
