using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SendSMS.Models.Responses
{
    /// <summary>
    /// Model for status SMS response. This is serializable record.
    /// </summary>
    [Serializable]
    public record ResponseStatusSMS
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
        /// When was sent
        /// </summary>
        [JsonProperty("data_envio")]
        [DataType(DataType.Date)]
        public DateTime SentDate { get; init; }

        /// <summary>
        /// Phone company which the number belongs
        /// </summary>
        [JsonProperty("operadora")]
        public string Company { get; init; }

        /// <summary>
        /// Response description
        /// </summary>
        [JsonProperty("descricao")]
        public string Description { get; init; }
    }
}
