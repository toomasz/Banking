using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using Banks.Fake;
using Banks.Base;

namespace WpfLearn.ViewModels
{
    [ImplementPropertyChanged]
    public class MainViewModel : BaseViewModel
    {
        public BankBase Bank { get; set;}

        public MainViewModel()
        {
            CurrentView = new LoginViewModel(this);
            Bank = new FakeBank();
        }
        public BaseViewModel CurrentView { get; set; }

        public void ChangeCurrentView(BaseViewModel newView)
        {
            this.CurrentView = newView;
        }
    }
}
