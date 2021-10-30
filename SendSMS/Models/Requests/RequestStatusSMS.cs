using System;
using System.ComponentModel.DataAnnotations;

namespace SendSMS.Models.Requests
{
    /// <summary>
    /// Model for requesting SMS status. This is a serializable record.
    /// </summary>
    [Serializable]
    public record RequestStatusSMS
    {
        /// <summary>
        /// Your API Key
        /// </summary>
        [Required]
        public string Key { get; init; }

        /// <summary>
        /// The SMS ID which you probably have stored.
        /// </summary>
        [Required]
        public long Id { get; init; }
    }
}
