using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfLearn.Commands
{
    public class RoutedCommand : ICommand
    {
        public RoutedCommand(Action action)
        {
            this.Action = action;
        }
        public RoutedCommand(Action<object> actionWithParam)
        {
            this.ActionWithParameter = actionWithParam;
        }
        Action Action;
        Action<object> ActionWithParameter;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (ActionWithParameter != null)
                this.ActionWithParameter(parameter);
            else
                this.Action();
        }
    }
}
