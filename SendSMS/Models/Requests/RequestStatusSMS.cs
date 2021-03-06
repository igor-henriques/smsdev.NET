namespace SendSMS.Models.Requests;

/// <summary>
/// Model for requesting SMS status. This is a serializable record.
/// </summary>
[Serializable]
public record RequestStatusSMS
{
    /// <summary>
    /// Your API Key. You can instead provide it on the service constructor.
    /// </summary>        
    public string Key { get; init; }

    /// <summary>
    /// The SMS ID which you probably have stored.
    /// </summary>
    [Required]
    public long Id { get; init; }
}
