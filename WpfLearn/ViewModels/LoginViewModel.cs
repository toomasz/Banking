using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using WpfLearn.Commands;


namespace WpfLearn.ViewModels
{
    [ImplementPropertyChanged]
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel(MainViewModel mainViewModel)
        {
            Username = "";
            Password = new SecureString();
            Password.Clear();
            LoginCommand = new RoutedCommand(OnLogin);
            MainViewModel = mainViewModel;
            LoginInProgress = false;
        }
        MainViewModel MainViewModel { get; set; }
        public bool LoginInProgress { get; set; }
        async void OnLogin(object parameter)
        {
            LoginError = false;
            LoginInProgress = true;
            var result = await MainViewModel.Bank.Login(Username, Password);
            LoginInProgress = false;
            if(!result.IsSuccess)
            {
                LoginError = true;
                LoginErrorMessage = result.ErrorMessage;
            }
            else
                MainViewModel.ChangeCurrentView(new BankViewModel(MainViewModel));
        }
        public bool LoginError { get; set; }
        public string LoginErrorMessage { get; set; }
        public string Username { get; set; }
        public SecureString Password { get; set; }
        public RoutedCommand LoginCommand { get; set; }
    }
}
