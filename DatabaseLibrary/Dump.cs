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

        public virtual void addItemtoDB(item anItem)
        {
            using (context)
            {
                context.items.Add(anItem);
                context.SaveChanges();
            }

        }

        //public 
    }
}
