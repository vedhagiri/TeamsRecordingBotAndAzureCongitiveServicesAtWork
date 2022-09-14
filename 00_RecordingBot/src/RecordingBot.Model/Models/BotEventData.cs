using Newtonsoft.Json;

namespace RecordingBot.Model.Models
{
    /// <summary>
    /// Class BotEventData.
    /// </summary>
    public class BotEventData
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
