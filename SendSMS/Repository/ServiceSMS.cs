using RestSharp;
using SendSMS.Interfaces;
using SendSMS.Models.Requests;
using SendSMS.Models.Responses;
using System.Threading.Tasks;

namespace SendSMS.Repository
{
    public class ServiceSMS : IServiceSMS
    {
        private readonly RestClient _client;
        private readonly RestRequest _request;
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

        public ResponseCancelSMS CancelSMS(RequestCancelSMS request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ResponseCancelSMS> CancelSMSAsync(RequestCancelSMS request)
        {
            throw new System.NotImplementedException();
        }

        public ResponseBalanceSMS GetBalance(RequestBalance request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ResponseBalanceSMS> GetBalanceAsync(RequestBalance request)
        {
            throw new System.NotImplementedException();
        }

        public ResponseFullReport GetFullReport(RequestFullReport request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ResponseFullReport> GetFullReportAsync(RequestFullReport request)
        {
            throw new System.NotImplementedException();
        }

        public ResponseStatusSMS GetStatusSMS(RequestStatusSMS request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ResponseStatusSMS> GetStatusSMSAsync(RequestStatusSMS request)
        {
            throw new System.NotImplementedException();
        }

        public ResponseSendSMS SendSMS(RequestSendSMS request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ResponseSendSMS> SendSMSAsync(RequestSendSMS request)
        {
            throw new System.NotImplementedException();
        }
    }
}
