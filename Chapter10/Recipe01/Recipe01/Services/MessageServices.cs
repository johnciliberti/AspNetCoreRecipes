using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Recipe01.Services
{
    public class AuthMessageSender : IEmailSender, ISmsSender
    {
        public TwilioOptions Options { get; } // set by the dependency injection system during startup
        public AuthMessageSender(IOptions<TwilioOptions> options)
        {
            Options = options.Value;
        }
        public Task SendEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }

        public Task SendSmsAsync(string number, string message)
        {
            TwilioClient.Init(Options.TwilioUser, Options.TwilioAuthToken);

            MessageResource.Create(
              to: new PhoneNumber(number),
              from: new PhoneNumber(Options.TwilioPhoneNumber),
              body: message);
            return Task.FromResult(0);
        }
    }
}
