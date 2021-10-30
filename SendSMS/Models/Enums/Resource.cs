using System.ComponentModel;

namespace SendSMS.Models.Enums
{
    public enum Resource
    {
        [Description("")]
        Empty,

        [Description("v1/balance")]
        Balance,

        [Description("v1/cancel")]
        CancelSMS,

        [Description("v1/report/total")]
        FullReport,

        [Description("v1/send")]
        SendSMS,

        [Description("v1/dlr")]
        StatusSMS
    }
}
