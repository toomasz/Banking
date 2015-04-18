using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using WpfLearn.Commands;

namespace WpfLearn.ViewModels
{
    [ImplementPropertyChanged]
    public class BankViewModel:BaseViewModel
    {
        public BankViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            LogoutCommand = new RoutedCommand(Logout);
        }
        MainViewModel MainViewModel { get; set; }
        public RoutedCommand LogoutCommand {get; set;}
        void Logout()
        {
            MainViewModel.ChangeCurrentView(new LoginViewModel(MainViewModel));
        }
    }
}
