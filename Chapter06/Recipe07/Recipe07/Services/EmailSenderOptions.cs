namespace Recipe07.Services
{
    public class EmailSenderOptions
    {
        public EmailSenderOptions()
        {
            EmailServerPort = 25;
            FromMailBoxName = "Gavel Shreds";
            FromMailBoxAddress = "noreply@gavelshreds.com";
        }


        public class AuthenticationSettings
        {
            public string EmailPassword { get; set; }
            public string EmailUserName { get; set; }
        }

        public EmailSenderOptions.AuthenticationSettings Authentication { get; set; }

        public string LocalDomain { get; set; }
        public string EmailServer { get; set; }
        public int EmailServerPort { get; set; }
        public string FromMailBoxName { get; set; }
        public string FromMailBoxAddress { get; set; }
    }
}
