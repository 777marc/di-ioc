namespace di_ioc.Models
{
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
}