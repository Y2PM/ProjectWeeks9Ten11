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

        public List<item> GetItemsFromDB()//:=Read
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

        public virtual void addItemtoDB(item anItem)//:=Write
        {
            using (context)
            {
                context.items.Add(anItem);
                context.SaveChanges();
            }
        }

        public void updateItemPrice(string itemNameToFind, decimal NewPrice)//:=Update
        {
            using (context)
            {
                var iteM = context.items.Find(itemNameToFind);
                iteM.item_price = NewPrice;
                context.SaveChanges();
            }
        }

        public void deleteItem(string itemName)//:=Delete
        {
            using (context)
            {
                var iteMs = context.items.Where(x => x.item_name == itemName);

                foreach (var itemm in iteMs)
                {
                    context.items.Remove(itemm);
                }
                context.SaveChanges();
            }
        }
    }
}
