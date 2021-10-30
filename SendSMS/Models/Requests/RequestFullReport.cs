using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SendSMS.Models.Requests
{
    /// <summary>
    /// Model for requesting full API report. This is a serializable record.
    /// </summary>
    [Serializable]
    public record RequestFullReport
    {
        /// <summary>
        /// Your API Key
        /// </summary>
        [Required]
        public string Key { get; init; }

        /// <summary>
        /// Initial date interval for full report
        /// </summary>
        [Required]
        [DataType(DataType.DateTime)]
        [JsonProperty("date_from")]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Final date interval for full report
        /// </summary>
        [Required]
        [DataType(DataType.DateTime)]
        [JsonProperty("date_to")]
        public DateTime DateTo { get; set; }
    }
}
