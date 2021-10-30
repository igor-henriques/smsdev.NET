using System;

namespace SendSMS.Models.Requests
{
    /// <summary>
    /// Model for requesting balance
    /// </summary>    
    [Serializable]
    public record RequestBalance
    {
        /// <summary>
        /// Your API Key. You can instead provide it on the service constructor.
        /// </summary>
        public string Key { get; init; }
    }
}
