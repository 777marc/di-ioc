namespace di_ioc.Models
{
    public class FormHandler
    {
        public IMailSender _mailSender { get; set; }
        public ILogger _logger { get; set; }

        public FormHandler(IMailSender mailSender, ILogger logger)
        {
            this._mailSender = mailSender;
            this._logger = logger;
        }

        public void Handle(string toAddress)
        {
            _mailSender.Send(toAddress, "This is Ninject example");
            _logger.WriteToLog("log: mail sent");
        }

    }
}