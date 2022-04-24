using System;

namespace Task___Class_OOP___20._04._2020
{
    class User
    {private string _username;
        public string Username { 
            get 
            {
                return _username;
            } 
            set
            {
                if (value.Length>6)
                {
                    value = _username;
                }
                else
                {
                    Console.WriteLine("Username 6 herfden boyuk olmalidir");
                }
            } 
        }

        public string Password 
        { get 
            {
                return _password;
            }
            set
            {
                if (CheckPass(Password))
                {
                    value = _password;
                }
                else
                {
                    Console.WriteLine("Password must be contains minimum 10 elements");
                }
            
            }
        }
        private string _password;
        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }



        public  bool CheckPass(string password)
        {
            if (password.Length>=10)
            {
                bool isNum = false;
                bool isUpper = false;
                bool isLower = false;

                foreach (char item in password)
                {
                    if (char.IsDigit(item))
                    {
                        isNum = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        isUpper = true;
                    }
                    else if (char.IsLower(item))
                    {
                        isLower = true;
                    }
                    
                   
                    
                }
                bool result = isNum && isUpper && isLower;
                return result;
               
            }
            return false;

        }



        public User()
        {

        }

        

        public string LoginInfo()
        {
            return $"Username: {Username}, Password: {_password}";
        }
    }
}
