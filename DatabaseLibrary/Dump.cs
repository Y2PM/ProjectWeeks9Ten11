using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
    public class Dump
    {
        public List<item> GetItemsFromDB()
        {
            List<item> itemNameList = new List<item>();

            using (var context = new ECommerceProjectSystemEntities())
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
            using (var context = new ECommerceProjectSystemEntities())
            {
                context.items.Add(anItem);
                context.SaveChanges();
            }

        }
    }
}
