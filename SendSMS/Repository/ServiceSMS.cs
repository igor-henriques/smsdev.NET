using Newtonsoft.Json;
using RestSharp;
using SendSMS.Interfaces;
using SendSMS.Models.Enums;
using SendSMS.Models.Requests;
using SendSMS.Models.Responses;
using SendSMS.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SendSMS.Repository
{
    public class ServiceSMS : IServiceSMS
    {
        private const string baseURL = "https://api.smsdev.com.br/";

        private readonly RestClient _client = new RestClient(baseURL);
        private RestRequest _request;
        private readonly string key;

        /// <summary>
        /// Optionally, initialize the service with the API Key so the service auto-provide it on the requests
        /// </summary>
        /// <param name="Key"></param>
        public ServiceSMS(string Key)
        {
            this.key = Key;
        }

        public ServiceSMS() { }

        public IEnumerable<ResponseCancelSMS> CancelSMS(RequestCancelSMS request)
        {
            try
            {
                request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

                var jsonRequest = JsonConvert.SerializeObject(request);

                this._request = new RestRequest(Resource.CancelSMS.GetDescription(), Method.POST, DataFormat.Json);

                this._request.AddJsonBody(jsonRequest);

                var response = _client.Execute(_request);

                return JsonConvert.DeserializeObject<IEnumerable<ResponseCancelSMS>>(response.Content);
            }
            catch (Exception) { throw; }
        }

        public async Task<IEnumerable<ResponseCancelSMS>> CancelSMSAsync(RequestCancelSMS request)
        {
            try
            {
                request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

                var jsonRequest = JsonConvert.SerializeObject(request);

                this._request = new RestRequest(Resource.CancelSMS.GetDescription(), Method.POST, DataFormat.Json);

                this._request.AddJsonBody(jsonRequest);

                var response = await _client.ExecuteAsync(_request);

                return JsonConvert.DeserializeObject<IEnumerable<ResponseCancelSMS>>(response.Content);
            }
            catch (Exception) { throw; }
        }

        public ResponseBalanceSMS GetBalance(RequestBalance request)
        {
            try
            {
                request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

                var jsonRequest = JsonConvert.SerializeObject(request);

                this._request = new RestRequest(Resource.Balance.GetDescription(), Method.POST, DataFormat.Json);

                this._request.AddJsonBody(jsonRequest);

                var response = _client.Execute(_request);

                return JsonConvert.DeserializeObject<ResponseBalanceSMS>(response.Content);
            }
            catch (Exception) { throw; }
        }

        public async Task<ResponseBalanceSMS> GetBalanceAsync(RequestBalance request)
        {
            try
            {
                request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

                var jsonRequest = JsonConvert.SerializeObject(request);

                this._request = new RestRequest(Resource.Balance.GetDescription(), Method.POST, DataFormat.Json);

                this._request.AddJsonBody(jsonRequest);

                var response = await _client.ExecuteAsync(_request);

                return JsonConvert.DeserializeObject<ResponseBalanceSMS>(response.Content);
            }
            catch (Exception) { throw; }
        }

        public ResponseFullReport GetFullReport(RequestFullReport request)
        {
            try
            {
                request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

                var jsonRequest = JsonConvert.SerializeObject(request);

                this._request = new RestRequest(Resource.FullReport.GetDescription(), Method.POST, DataFormat.Json);

                this._request.AddJsonBody(jsonRequest);

                var response = _client.Execute(_request);

                return JsonConvert.DeserializeObject<ResponseFullReport>(response.Content);
            }
            catch (Exception) { throw; }
        }

        public async Task<ResponseFullReport> GetFullReportAsync(RequestFullReport request)
        {
            try
            {
                request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

                var jsonRequest = JsonConvert.SerializeObject(request);

                this._request = new RestRequest(Resource.FullReport.GetDescription(), Method.POST, DataFormat.Json);

                this._request.AddJsonBody(jsonRequest);

                var response = await _client.ExecuteAsync(_request);

                return JsonConvert.DeserializeObject<ResponseFullReport>(response.Content);
            }
            catch (Exception) { throw; }
        }

        public ResponseStatusSMS GetStatusSMS(RequestStatusSMS request)
        {
            try
            {
                request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

                var jsonRequest = JsonConvert.SerializeObject(request);

                this._request = new RestRequest(Resource.StatusSMS.GetDescription(), Method.POST, DataFormat.Json);

                this._request.AddJsonBody(jsonRequest);

                var response = _client.Execute(_request);

                return JsonConvert.DeserializeObject<ResponseStatusSMS>(response.Content);
            }
            catch (System.Exception) { throw; }
        }

        public async Task<ResponseStatusSMS> GetStatusSMSAsync(RequestStatusSMS request)
        {
            try
            {
                request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

                var jsonRequest = JsonConvert.SerializeObject(request);

                this._request = new RestRequest(Resource.StatusSMS.GetDescription(), Method.POST, DataFormat.Json);

                this._request.AddJsonBody(jsonRequest);

                var response = await _client.ExecuteAsync(_request);

                return JsonConvert.DeserializeObject<ResponseStatusSMS>(response.Content);
            }
            catch (Exception) { throw; }
        }

        public ResponseSendSMS SendSMS(RequestSendSMS request)
        {
            try
            {
                request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

                var jsonRequest = JsonConvert.SerializeObject(request);

                this._request = new RestRequest(Resource.SendSMS.GetDescription(), Method.POST, DataFormat.Json);

                this._request.AddJsonBody(jsonRequest);

                var response = _client.Execute(_request);

                return JsonConvert.DeserializeObject<ResponseSendSMS>(response.Content);
            }
            catch (Exception) { throw; }
        }

        public async Task<ResponseSendSMS> SendSMSAsync(RequestSendSMS request)
        {
            try
            {
                request = string.IsNullOrEmpty(key) ? request : request with { Key = this.key };

                var jsonRequest = JsonConvert.SerializeObject(request);

                this._request = new RestRequest(Resource.SendSMS.GetDescription(), Method.POST, DataFormat.Json);

                this._request.AddJsonBody(jsonRequest);

                var response = await _client.ExecuteAsync(_request);

                return JsonConvert.DeserializeObject<ResponseSendSMS>(response.Content);
            }
            catch (Exception) { throw; }
        }
    }
}
