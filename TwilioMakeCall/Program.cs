using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


namespace TwilioMakeCall
{
    class Program
    {
        static void Main(string[] args)
        {

            // Find your Account Sid and Token at twilio.com/console
            const string accountSid = "xxxxxxxxxxxxxxxxxxxxx";
            const string authToken = "xxxxxxxxxxxxxxxxxxxxxx";

            TwilioClient.Init(accountSid, authToken);

            var call = CallResource.Create(
                url: new Uri("http://demo.twilio.com/docs/voice.xml"),
                to: new Twilio.Types.PhoneNumber("+xxxxxxxxxxxxxxxxx"),
                from: new Twilio.Types.PhoneNumber("+xxxxxxxxxxxxxxxx")
            );

            Console.WriteLine(call.Sid);


            Console.WriteLine("Hello World!");
        }
    }
}
