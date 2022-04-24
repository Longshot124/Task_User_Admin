using System;
using static Task___Class_OOP___20._04._2020.User;
using static Task___Class_OOP___20._04._2020.Admin;

namespace Task___Class_OOP___20._04._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            


            User user = new User();
            

            do
            {
                Console.WriteLine("Enter your Username");
                username= Console.ReadLine();

            } while (username.Length<6);

            string password;
            do
            {
                Console.WriteLine("Enter your Password");

                password = Console.ReadLine();

            } while (!user.CheckPass(password));

            Console.WriteLine("Are you Super Admin??? guya =)");
            bool isSuper = false;
            string IsSuperAdmin = Console.ReadLine();


            if (IsSuperAdmin.ToLower() == "y")
            {
                
                isSuper = true;
            }
            else if(IsSuperAdmin.ToLower() == "n")
            {
                isSuper = false ;
                Console.WriteLine("Bextinizi bir daha sinayin");
                
            }



            Console.WriteLine("Enter your Section");
            string section = Console.ReadLine();

            Admin admin = new Admin(username,password,section,isSuper);

            Console.WriteLine(admin.getInfo());


           

            
           
        }


        //public static bool CheckPass(string password)
        //{
        //    if (password.Length >= 10)
        //    {
        //        bool isNum = false;
        //        bool isUpper = false;
        //        bool isLower = false;
        //        bool isElement = false;

        //        foreach (char item in password)
        //        {
        //            if (char.IsDigit(item))
        //            {
        //                isNum = true;
        //            }
        //            else if (char.IsUpper(item))
        //            {
        //                isUpper = true;
        //            }
        //            else if (char.IsLower(item))
        //            {
        //                isLower = true;
        //            }
        //            else if (char.IsPunctuation(item))
        //            {
        //                isElement = true;
        //            }



        //        }
        //        bool result = isNum && isUpper && isLower && isElement;
        //        return result;

        //    }
        //    return false;

        //}




    }
}
