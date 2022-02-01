namespace SendSMS.Models.Responses;

/// <summary>
/// Model for balance SMS response. This is serializable record.
/// </summary>
[Serializable]
public record ResponseBalanceSMS
{
    /// <summary>
    /// Response status. Usually, "OK" for 200 and "ERRO" for anything else
    /// </summary>
    [JsonProperty("situacao")]
    public string Status { get; init; }

    /// <summary>
    /// Your current balance
    /// </summary>
    [JsonProperty("saldo_sms")]
    public int Balance { get; init; }

    /// <summary>
    /// Response description
    /// </summary>
    [JsonProperty("descricao")]
    public string Description { get; init; }
}
