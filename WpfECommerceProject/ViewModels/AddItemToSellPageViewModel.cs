using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfECommerceProject.ViewModels
{
    public class AddItemToSellPageViewModel : BaseViewModel
    {
        //Injection.
        Dump dump;
        item item1 = new item();
        string oldName;

        public AddItemToSellPageViewModel(Dump givenDump, item givenItem1)
        {
            dump = givenDump;
            item1 = givenItem1;
            oldName = name;
        }

        public AddItemToSellPageViewModel()
        {
            name = "name here";
            price = "0";

            oldName = name;

            dump = new Dump(new ECommerceProjectSystemEntities());

        }
        //------------------------------------------------        

        private string _price;

        public string price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged("price");
            }
        }

        private string _name;

        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name");
            }
        }


        /////////////////////////////////////////////////////
        private ICommand _addSomeItem;

        public ICommand addSomeItem
        {
            get
            {
                if (_addSomeItem == null)
                {
                    _addSomeItem = new Command(addToDB, canAddToDB);
                }
                return _addSomeItem;
            }
            set { _addSomeItem = value; }
        }

        private bool canAddToDB()
        {
            return true;//Could add logic to check if this item already exists.
        }

        public virtual void addToDB()//Needs to be virtual to be tested using moq.
        {

            item1 = new item() { item_name = name, item_price = Int32.Parse(price) };

            dump.addItemtoDB(item1);
        }
    }
}
