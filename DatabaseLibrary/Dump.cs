using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
    public class Dump
    {

        ECommerceProjectSystemEntities context;//Injection.

        public Dump(ECommerceProjectSystemEntities givenContext)//Construction.
        {
            context = givenContext;
        }

        //Constructor overload 1:
        public Dump()
        {

        }

        public List<item> GetItemsFromDB()
        {
            List<item> itemNameList = new List<item>();

            using (context)
            {
                foreach (var item in context.items)
                {
                    itemNameList.Add(item);
                }
            }
            return itemNameList;
        }

        public void addItemtoDB(item anItem)
        {
            using (context)
            {
                context.items.Add(anItem);
                context.SaveChanges();
            }

        }
    }
}
