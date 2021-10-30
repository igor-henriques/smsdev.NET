using System;
using System.ComponentModel.DataAnnotations;

namespace SendSMS.Models.Requests
{
    /// <summary>
    /// Model for requesting balance
    /// </summary>    
    [Serializable]
    public record RequestBalance
    {
        /// <summary>
        /// Your API Key
        /// </summary>
        [Required]
        public string Key { get; init; }
    }
}
