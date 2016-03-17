using DatabaseLibrary;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfECommerceProject.ViewModels;

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
                Console.WriteLine(item.item_name + " £" + item.item_price + "p");
            }
            Console.ReadLine();
            */

            /*
            //Testing delete item in data base.
            Dump dump = new Dump(new ECommerceProjectSystemEntities());            
            dump.deleteItem("name here");
            */

            /*
            //Testing adding an item to database
            Dump dump = new Dump(new ECommerceProjectSystemEntities());
            item item1 = new item() { item_name = "Money", item_price = 68 };
            dump.addItemtoDB(item1);
            */

            /*
            Dump dump = new Dump(new ECommerceProjectSystemEntities());
            Console.WriteLine(dump.GetItemsFromDB().Count);//Testing printing out # of item(s).
            Console.ReadLine();
            */

            /*
            //Testing update item in database:
            Dump dump = new Dump(new ECommerceProjectSystemEntities());
            dump.updateItemPrice("NuclearWinterGenerator", 3000);
            */
            
            /*
            //Testing the logger function.
            string message = "Hello 2";
            Console.WriteLine(message);
            logger.Info(message);
            Console.ReadLine();
            */

        }
    }
}
