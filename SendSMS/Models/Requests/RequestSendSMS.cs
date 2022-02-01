namespace SendSMS.Models.Requests;

/// <summary>
/// Model for sending SMS. This is a serializable record.
/// </summary>
[Serializable]
public record RequestSendSMS
{
    /// <summary>
    /// Your API Key. You can instead provide it on the service constructor.
    /// </summary>
    public string Key { get; init; }

    /// <summary>
    /// Service Type. 9 For SMS.
    /// </summary>
    [Required]
    public byte Type { get { return 9; } }

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
    /// OPTIONAL: User reference for message identification.
    /// </summary>
    [MaxLength(100)]
    public string Refer { get; init; }

    /// <summary>
    /// OPTIONAL: Determine whether is pop-up message or not
    /// </summary>
    public bool Flash { get; init; }

    /// <summary>
    /// OPTIONAL: Date schedule for send message
    /// </summary>
    [DataType(DataType.Date)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTime JobDate { get; init; }

    /// <summary>
    /// OPTIONAL: Time schedule for send message
    /// </summary>
    [DataType(DataType.Time)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTime JobTime { get; init; }
}
