using Ninject.Modules;  
using Ninject;

namespace di_ioc.Models
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailSender>().To<MailSender>();
            Bind<ILogger>().To<Logger>();
        }
    }
}