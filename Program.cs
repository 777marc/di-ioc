using System;
using System.Reflection;
using di_ioc.Models;
using Ninject;

namespace di_ioc
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var mailSender = kernel.Get<IMailSender>();
            var logger = kernel.Get<ILogger>();

            var formHandler = new FormHandler(mailSender, logger);
            formHandler.Handle("test@test.com");

            Console.ReadLine();
        }
    }
}
