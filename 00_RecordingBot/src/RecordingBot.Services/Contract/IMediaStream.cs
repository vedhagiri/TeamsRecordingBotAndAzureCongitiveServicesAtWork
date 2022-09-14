// ***********************************************************************
// Assembly         : RecordingBot.Services
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="IMediaStream.cs" company="Recosenselabs.com">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.Graph.Communications.Calls;
using Microsoft.Skype.Bots.Media;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecordingBot.Services.Contract
{
    /// <summary>
    /// Interface IMediaStream
    /// </summary>
    public interface IMediaStream
    {
        /// <summary>
        /// Appends the audio buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="participant">The participant.</param>
        /// <returns>Task.</returns>
        Task AppendAudioBuffer(AudioMediaBuffer buffer, List<IParticipant> participant);
        /// <summary>
        /// Ends this instance.
        /// </summary>
        /// <returns>Task.</returns>
        Task End();
    }
}
