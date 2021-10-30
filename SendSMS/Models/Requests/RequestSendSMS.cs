using System;
using System.ComponentModel.DataAnnotations;

namespace SendSMS.Models.Requests
{
    /// <summary>
    /// Model for sending SMS. This is a serializable record.
    /// </summary>
    [Serializable]
    public record RequestSendSMS
    {
        /// <summary>
        /// Your API Key
        /// </summary>
        [Required]
        public string Key { get; init; }

        /// <summary>
        /// Service Type. 9 For SMS.
        /// </summary>
        [Required]
        public byte Type { get; init; }

        /// <summary>
        /// Phone number which will receive the message
        /// </summary>
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Number { get; init; }

        /// <summary>
        /// Message itself
        /// </summary>
        [Required]
        public string Msg { get; init; }

        /// <summary>
        /// User reference for message identification
        /// </summary>
        [MaxLength(100)]
        public string Refer { get; init; }

        /// <summary>
        /// Determine whether is pop-up message or not
        /// </summary>
        public bool Flash { get; init; }

        /// <summary>
        /// Date schedule for send message
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime JobDate { get; init; }

        /// <summary>
        /// Time schedule for send message
        /// </summary>
        [DataType(DataType.Time)]
        public DateTime JobTime { get; init; }
    }
}