using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationUWP.Model
{
    class Person
    {
        private string _name;
        private string _password;

        public Person(string name, string password )
        {
            _name = name;
            _password = password;
        }

        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        public string Password
        {
            get { return _password; }

            set { _password = value; }
        }
        
    }
}
