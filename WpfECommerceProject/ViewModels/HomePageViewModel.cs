using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfECommerceProject.ViewModels
{
    class HomePageViewModel : BaseViewModel
    {
        private ICommand _navigateCommand;

        public ICommand navigateCommand
        {
            get
            {
                if (_navigateCommand == null)
                {
                    _navigateCommand = new Command(navigateToPageTwo, canNavigateToPageTwo);
                }
                return _navigateCommand;
            }
            set { _navigateCommand = value; }
        }

        private bool canNavigateToPageTwo()
        {
            return true;
        }

        private void navigateToPageTwo()
        {
            ViewModelForPageChange vm = App.Current.MainWindow.DataContext as ViewModelForPageChange;
            vm.page = "BuyItemsPage.xaml";
        }
    }
}
