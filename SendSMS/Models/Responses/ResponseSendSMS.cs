using Newtonsoft.Json;
using System;

namespace SendSMS.Models.Responses
{
    /// <summary>
    /// Model for send SMS response. This is serializable record.
    /// </summary>
    [Serializable]
    public record ResponseSendSMS
    {
        /// <summary>
        /// Response status. Usually, "OK" for 200 and "ERRO" for anything else
        /// </summary>
        [JsonProperty("situacao")]
        public string Status { get; init; }

        /// <summary>
        /// Error code, when not succesfull
        /// </summary>
        [JsonProperty("codigo")]
        public int ErrorCode { get; init; }

        /// <summary>
        /// The SMS unique ID. Store this.
        /// </summary>
        public long Id { get; init; }

        /// <summary>
        /// Response description
        /// </summary>
        [JsonProperty("descricao")]
        public string Description { get; init; }
    }
}
