using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfECommerceProject.ViewModels
{
    public class DataBaseViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<item> _items;

        public ObservableCollection<item> items
        {
            get
            { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged("items");
            }
        }


        private Dump dump;

        public DataBaseViewModel()//constructor for normal use
        {
            dump = new Dump(new ECommerceProjectSystemEntities());

            items = new ObservableCollection<item>();
            items = new ObservableCollection<item>(dump.GetItemsFromDB());
        }

        public DataBaseViewModel(Dump injectedDump)//Constructor for tests case using mock
        {
            dump = injectedDump;

            items = new ObservableCollection<item>();
            items = new ObservableCollection<item>(dump.GetItemsFromDB());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        //
    }
}
