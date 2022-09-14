// ***********************************************************************
// Assembly         : RecordingBot.Model
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="JoinURLResponse.cs" company="Recosenselabs.com">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace RecordingBot.Model.Models
{
    /// <summary>
    /// Class JoinURLResponse.
    /// </summary>
    public partial class JoinURLResponse
    {
        /// <summary>
        /// Gets or sets the call identifier.
        /// </summary>
        /// <value>The call identifier.</value>
        [JsonProperty("callId")]
        public object CallId { get; set; }

        /// <summary>
        /// Gets or sets the scenario identifier.
        /// </summary>
        /// <value>The scenario identifier.</value>
        [JsonProperty("scenarioId")]
        public Guid ScenarioId { get; set; }

        /// <summary>
        /// Gets or sets the call.
        /// </summary>
        /// <value>The call.</value>
        [JsonProperty("call")]
        public string Call { get; set; }
    }
}
