using DatabaseLibrary;
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
            /*
            //Testing the GetItems method
            Dump dump = new Dump(new ECommerceProjectSystemEntities());

            List<item> itemDumpList = dump.GetItemsFromDB();

            foreach (var item in itemDumpList)
            {
                Console.WriteLine(item.item_name);
            }
            Console.ReadLine();
            */

            /*
            //Testing adding an item to database
            Dump dump = new Dump(new ECommerceProjectSystemEntities());
            item item1 = new item() { item_name = "Money", item_price = 68 };
            dump.addItemtoDB(item1);
            */

            //Console.WriteLine(dump.GetItemsFromDB().Count);//Testing printing out # of item(s).
            //Console.ReadLine();
            

            /*
            //Testing the logger function.
            string message = "Hello";
            Console.WriteLine(message);
            logger.Info(message);
            Console.ReadLine();
            */
        }
    }
}
