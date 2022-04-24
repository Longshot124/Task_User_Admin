using System;
using System.Collections.Generic;
using System.Text;

namespace Task___Class_OOP___20._04._2020
{
    class Admin : User
    {
        public bool IsSuperAdmin;
        public string Section;

       
        public Admin(string username, string password, string section,bool isSuperAdmin=false ) : base(username, password)
        {
            //Username = username;
            //Password = password;
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }
        public Admin()
        {

        }

        public string getInfo()
        {
            return ($"username: {Username}, password: {Password}, issuperadmin: {IsSuperAdmin}, section: {Section}");

                /*(/*"Username :{0} Password:{1} IsSuperAdmin: {3}, Section: {4}", Username, Password, IsSuperAdmin, Section*//*); */

        }
    }

    
}
