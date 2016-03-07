using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfECommerceProject.ViewModels
{
    class ViewModelForPageChange : BaseViewModel
    {
        private string _page;

        public string page
        {
            get { return _page; }
            set 
            {
                _page = value;
                OnPropertyChanged("page");
            }
        }

        public ViewModelForPageChange()
        {
            page = "HomePage.xaml";
        }

    }
}
