﻿using SendSMS.Models.Requests;
using SendSMS.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SendSMS.Interfaces
{
    public interface IServiceSMS
    {
        ResponseBalanceSMS GetBalance(RequestBalance request);
        Task<ResponseBalanceSMS> GetBalanceAsync(RequestBalance request);
        IEnumerable<ResponseCancelSMS> CancelSMS(RequestCancelSMS request);
        Task<IEnumerable<ResponseCancelSMS>> CancelSMSAsync(RequestCancelSMS request);
        ResponseFullReport GetFullReport(RequestFullReport request);
        Task<ResponseFullReport> GetFullReportAsync(RequestFullReport request);
        ResponseSendSMS SendSMS(RequestSendSMS request);
        Task<ResponseSendSMS> SendSMSAsync(RequestSendSMS request);
        ResponseStatusSMS GetStatusSMS(RequestStatusSMS request);
        Task<ResponseStatusSMS> GetStatusSMSAsync(RequestStatusSMS request);
    }
}
