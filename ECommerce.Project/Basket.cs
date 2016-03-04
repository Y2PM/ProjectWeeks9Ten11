using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Project
{
    public class Basket
    {

        public List<Item> itemsList;
        public Basket(List<Item> givenItemsList)
        {
            itemsList = givenItemsList;
        }

        public void addItem(Item anItem)
        {
            itemsList.Add(anItem);
        }

        public void removeItem(Item anItem)
        {
            itemsList.Remove(anItem);
        }


    }
}
