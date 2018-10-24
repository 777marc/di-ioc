using System;

namespace di_ioc.Models
{
    public class MailSender : IMailSender
    {
        public void Send(string toAddress, string subject)
        {
            Console.WriteLine("Sending mail to [{0}] with subject [{1}]", toAddress, subject);
        }

    }
}