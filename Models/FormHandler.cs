namespace di_ioc.Models
{
    public class FormHandler
    {
        public IMailSender _mailSender { get; set; }

        public FormHandler(IMailSender mailSender)
        {
            this._mailSender = mailSender;
        }

        public void Handle(string toAddress)
        {
            _mailSender.Send(toAddress, "This is Ninject example");
        }

    }
}