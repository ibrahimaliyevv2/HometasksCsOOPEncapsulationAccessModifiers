using System;
namespace HometasksCsOOPEncapsulationAccessModifiers
{
    public class User
    {
        public User(string userName)
        {
            this.UserName = userName;
        }

        private string _userName;
        private string _password;


        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                    this._userName = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length >= 8 || value.Length <= 25 && HasDigit(value) && HasLower(value) && HasUpper(value))
                {
                        this._password = value;
                }
            }
        }
            public bool HasDigit(string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item)) return true;
            }
            return false;
        }
        public bool HasUpper(string str)
        {
            foreach (var item in str)
            {
                if (char.IsUpper(item)) return true;
            }
            return false;
        }
        public bool HasLower(string str)
        {
            foreach (var item in str)
            {
                if (char.IsLower(item)) return true;
            }
            return false;
        }
    }

    }
