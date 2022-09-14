// ***********************************************************************
// Assembly         : RecordingBot.Model
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="ParticipantData.cs" company="Recosenselabs.com">
//     Copyright �  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.Graph.Communications.Calls;
using System.Collections.Generic;

namespace RecordingBot.Model.Models
{
    /// <summary>
    /// Class ParticipantData.
    /// </summary>
    public class ParticipantData
    {
        /// <summary>
        /// Gets or sets the added resources.
        /// </summary>
        /// <value>The added resources.</value>
        public ICollection<IParticipant> AddedResources { get; set; }
        /// <summary>
        /// Gets or sets the removed resources.
        /// </summary>
        /// <value>The removed resources.</value>
        public ICollection<IParticipant> RemovedResources { get; set; }
    }
}
