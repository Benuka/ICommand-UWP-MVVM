using NavigationUWP.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace NavigationUWP.ViewModel
{
    public class MainViewModel  : ViewModelBase
    {

        public ICommand SubmitDataCommand => new Command(OnSubmitDataClick);

        public MainViewModel()
        {
           // _name = "Sithara";
        }

        private string _name;
        private string _password;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyPropertyChanged("Password");
            }
        }

        public async void OnSubmitDataClick()
        {
            var xname = Name;
            var xpassword = Password;
            var dialog = new MessageDialog(xname +" --- " + xpassword);
            await dialog.ShowAsync();
            // save to db or call an API
        }
    }
}
