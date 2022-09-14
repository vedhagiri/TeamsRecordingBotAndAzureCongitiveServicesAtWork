// ***********************************************************************
// Assembly         : RecordingBot.Model
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 09-07-2022
// ***********************************************************************
// <copyright file="JoinCallBody.cs" company="Recosenselabs.com">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace RecordingBot.Model.Models
{
    /// <summary>
    /// The join call body.
    /// </summary>
    public class JoinCallBody
    {
        /// <summary>
        /// Gets or sets the Teams meeting join URL.
        /// </summary>
        /// <value>The join URL.</value>
        public string JoinURL { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// Teams client does not allow changing of ones own display name.
        /// If display name is specified, we join as anonymous (guest) user
        /// with the specified display name.  This will put bot into lobby
        /// unless lobby bypass is disabled.
        /// Side note: if display name is specified, the bot will not have
        /// access to UnmixedAudioBuffer in the Skype Media libraries.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName { get; set; }

        public string TranscriptionLanguage { get; set; } = "en-US";

        public string[] TranslationLanguages { get; set; } = { "de-DE" };
    }
}
