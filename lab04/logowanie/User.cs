using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logowanie
{
    public class User
    {
        private string email;
        private string haslo;

        public User(string email,string haslo)
        {
            this.email = email;
            this.haslo = haslo;
        }

        public bool logowanie(string email,string haslo)
        {
            if(this.email.Equals(email)&& this.haslo.Equals(haslo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
