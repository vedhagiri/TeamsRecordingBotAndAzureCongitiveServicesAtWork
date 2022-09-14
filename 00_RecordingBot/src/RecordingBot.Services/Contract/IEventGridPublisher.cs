// ***********************************************************************
// Assembly         : RecordingBot.Services
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 09-03-2022
// ***********************************************************************
// <copyright file="IEventGridPublisher.cs" company="Recosenselabs.com">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace RecordingBot.Services.Contract
{
    /// <summary>
    /// Interface IEventPublisher
    /// </summary>
    public interface IEventPublisher
    {
        /// <summary>
        /// Publishes the specified subject.
        /// </summary>
        /// <param name="Subject">The subject.</param>
        /// <param name="Message">The message.</param>
        /// <param name="TopicName">Name of the topic.</param>
        void Publish(string Subject, string Message, string TopicName = "");
    }
}
