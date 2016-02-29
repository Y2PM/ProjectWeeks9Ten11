using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ECommerce.Project
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger("Program.cs");

        static void Main(string[] args)
        {
            //Testing the logger function.
            string message = "Hello";
            Console.WriteLine(message);
            logger.Info(message);
            Console.ReadLine();
        }
    }
}
