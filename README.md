# smsdev.NET

.NET 6 SMS Service Library. Works by wraping smsdev.com.br API.

## Installation
Clone this, build (or just get on releases) and reference the DLL on your project.<br>PS.: .NET 6 SDK required

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
Is also possible to define the interface as a singleton, if you're using D.I.

## Calling asynchronous method
``` C#
using SendSMS.Interfaces;
using SendSMS.Models.Requests;
using SendSMS.Models.Responses;
using SendSMS.Repository;

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

> Check classes and properties summary for better understanding about them.<br>

* VS Code Analysis (for fun)

| Maintainability Index | Cyclomatic Complexity | Depth of Inheritance | Class Coupling | Lines of Source Code | Lines of Executable Code
| --------------------- |:---------------------:| --------------------:|---------------:|---------------------:|-------------------------:|
| ![#84fc03](https://via.placeholder.com/15/c5f015/000000?text=+)   89 | 129 | 3 | 49 | 689 | 179 |
