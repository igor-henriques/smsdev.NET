namespace SendSMS.Interfaces;

public interface IServiceSMS
{
    Task<ResponseBalanceSMS> GetBalanceAsync(RequestBalance request);
    Task<IEnumerable<ResponseCancelSMS>> CancelSMSAsync(RequestCancelSMS request);
    Task<ResponseFullReport> GetFullReportAsync(RequestFullReport request);
    Task<ResponseSendSMS> SendSMSAsync(RequestSendSMS request);
    Task<ResponseStatusSMS> GetStatusSMSAsync(RequestStatusSMS request);
}
