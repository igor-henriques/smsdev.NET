using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SendSMS.Models.Responses
{
    /// <summary>
    /// Model for full report response. This is serializable record.
    /// </summary>
    [Serializable]
    public record ResponseFullReport
    {
        /// <summary>
        /// The SMS unique ID.
        /// </summary>
        public long Id { get; init; }

        /// <summary>
        /// Error code, when not succesfull
        /// </summary>
        [JsonProperty("codigo")]
        public int ErrorCode { get; init; }

        /// <summary>
        /// Initial date interval for full report
        /// </summary>
        [Required]
        [DataType(DataType.DateTime)]
        [JsonProperty("data_inicio")]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Final date interval for full report
        /// </summary>
        [Required]
        [DataType(DataType.DateTime)]
        [JsonProperty("data_fim")]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Count sent SMS in the given period
        /// </summary>
        [JsonProperty("enviada")]
        public int SentCount { get; init; }

        /// <summary>
        /// Count received SMS in the given period
        /// </summary>
        [JsonProperty("recebida")]
        public int ReceivedCount { get; init; }

        /// <summary>
        /// Count blacklisted SMS in the given period
        /// </summary>
        [JsonProperty("blacklist")]
        public int BlacklistCount { get; init; }

        /// <summary>
        /// Count cancelled SMS in the given period
        /// </summary>
        [JsonProperty("cancelada")]
        public int CancelledCount { get; set; }

        /// <summary>
        /// Credits spent in the given period
        /// </summary>
        [JsonProperty("qtd_credito")]
        public int BalanceCount { get; set; }

        /// <summary>
        /// Response description
        /// </summary>        
        [JsonProperty("descricao")]
        public string Description { get; init; }
    }
}
