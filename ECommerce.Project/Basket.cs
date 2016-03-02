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

        //Overload1:
        public Basket()
        {
        }

        public void addItem(Item anItem, List<Item> itemsList)
        {

            itemsList.Add(anItem);

        }

        public void removeItem(Item anItem, List<Item> itemsList)
        {

            itemsList.Remove(anItem);

        }


    }
}
