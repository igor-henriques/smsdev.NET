namespace SendSMS.Repository;

public class ServiceSMS : IServiceSMS
{
    private const string baseURL = "https://api.smsdev.com.br/";

    private readonly RestClient _client = new RestClient(baseURL);
    private RestRequest _request;
    private readonly string key;

    /// <summary>
    /// Optionally, initialize the service with the API Key so the service auto-provide it on the requests
    /// </summary>
    /// <param name="Key">Key obtained on the smsdev.com.br platform</param>
    public ServiceSMS(string Key)
    {
        this.key = Key;
    }

    public ServiceSMS() { }


    public async Task<IEnumerable<ResponseCancelSMS>> CancelSMSAsync(RequestCancelSMS request)
    {
        try
        {
            request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

            var jsonRequest = JsonConvert.SerializeObject(request);

            this._request = new RestRequest(Resource.CancelSMS, Method.Post);

            this._request.AddJsonBody(jsonRequest);

            var response = await _client.ExecuteAsync<IEnumerable<ResponseCancelSMS>>(_request).ConfigureAwait(false);

            return response.Data;
        }
        catch (Exception) { throw; }
    }

    public async Task<ResponseBalanceSMS> GetBalanceAsync(RequestBalance request)
    {
        try
        {
            request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

            var jsonRequest = JsonConvert.SerializeObject(request);

            this._request = new RestRequest(Resource.Balance, Method.Post);

            this._request.AddJsonBody(jsonRequest);

            var response = await _client.ExecuteAsync<ResponseBalanceSMS>(_request).ConfigureAwait(false);

            return response.Data;
        }
        catch (Exception) { throw; }
    }

    public async Task<ResponseFullReport> GetFullReportAsync(RequestFullReport request)
    {
        try
        {
            request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

            var jsonRequest = JsonConvert.SerializeObject(request);

            this._request = new RestRequest(Resource.FullReport, Method.Post);

            this._request.AddJsonBody(jsonRequest);

            var response = await _client.ExecuteAsync<ResponseFullReport>(_request).ConfigureAwait(false);

            return response.Data;
        }
        catch (Exception) { throw; }
    }

    public async Task<ResponseStatusSMS> GetStatusSMSAsync(RequestStatusSMS request)
    {
        try
        {
            request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

            var jsonRequest = JsonConvert.SerializeObject(request);

            this._request = new RestRequest(Resource.StatusSMS, Method.Post);

            this._request.AddJsonBody(jsonRequest);

            var response = await _client.ExecuteAsync<ResponseStatusSMS>(_request).ConfigureAwait(false);

            return response.Data;
        }
        catch (Exception) { throw; }
    }

    public async Task<ResponseSendSMS> SendSMSAsync(RequestSendSMS request)
    {
        try
        {
            request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

            var jsonRequest = JsonConvert.SerializeObject(request);

            this._request = new RestRequest(Resource.SendSMS, Method.Post);

            this._request.AddJsonBody(jsonRequest);

            var response = await _client.ExecuteAsync<ResponseSendSMS>(_request).ConfigureAwait(false);

            return response.Data;
        }
        catch (Exception) { throw; }
    }
}