# smsdev.NET

.NET 5 SMS Service Library. Works by wraping smsdev.com.br API.

## Installation
Clone this, build and reference the DLL on your project.<br>PS.: .NET 5 SDK required

## Usage
* First get your key on https://www.smsdev.com.br/<br>
* Declare and assign IServiceSMS interface on your class constructor (apiKey parameter is optional):
``` C#
private readonly IServiceSMS smsService;

public class Foo()
{
    this.smsService = new ServiceSMS(apiKey);
}
```
Is also possible to define the service as a singleton, if you're using DI.

## Calling asynchronous method
``` C#
using SendSMS.Interfaces;
using SendSMS.Models.Requests;
using SendSMS.Models.Responses;
using SendSMS.Repository;
```

``` C#
public async Task<ResponseSendSMS> SendSMS(string number, string message)
{    
    var request = new RequestSendSMS
    {
        Key = "ENTER_KEY_HERE",         //OPTIONAL. Notice that Key property is only optional if you provide it on the ServiceSMS constructor
        Number = number,
        Msg = message,
        Refer = "RandomOptionalRefer",  //OPTIONAL
        Flash = true,                   //OPTIONAL
        JobDate = new DateTime(),       //OPTIONAL
        JobTime = new DateTime(),       //OPTIONAL
    };
    
    var response = await serviceSMS.SendSMSAsync(request);
}
```

## Calling synchronous method
``` C#
public ResponseSendSMS SendSMS(string number, string message)
{    
    var request = new RequestSendSMS
    {
        Key = "ENTER_KEY_HERE",         //OPTIONAL. Notice that Key property is only optional if you provide it on the ServiceSMS constructor
        Number = number,
        Msg = message,
        Refer = "RandomOptionalRefer",  //OPTIONAL
        Flash = true,                   //OPTIONAL
        JobDate = new DateTime(),       //OPTIONAL
        JobTime = new DateTime(),       //OPTIONAL
    };
    
    var response = serviceSMS.SendSMS(request);
}
```

* Check classes and properties summary for better understanding about them.
