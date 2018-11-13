using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationUWP.Util
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action _onSubmitClick;

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, new EventArgs());
        }

        public Command(Action onSubmitClick)
        {
            this._onSubmitClick = onSubmitClick;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._onSubmitClick();
        }
    }
}
