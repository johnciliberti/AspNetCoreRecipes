using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using Microsoft.Extensions.Options;

namespace Recipe07.Services
{
    public class AuthMessageSender : IEmailSender, ISmsSender
    {
        private EmailSenderOptions _Options;
        public AuthMessageSender(IOptions<EmailSenderOptions> options)
        {
            _Options = options.Value;
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_Options.FromMailBoxName, _Options.FromMailBoxAddress));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = message };
            using (var client = new SmtpClient())
            {
                client.LocalDomain = _Options.LocalDomain;
                await client.ConnectAsync(_Options.EmailServer, _Options.EmailServerPort, SecureSocketOptions.StartTls).ConfigureAwait(false);
                await client.AuthenticateAsync(_Options.Authentication.EmailUserName, _Options.Authentication.EmailPassword);
                await client.SendAsync(emailMessage).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
            }
        }

        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
}
