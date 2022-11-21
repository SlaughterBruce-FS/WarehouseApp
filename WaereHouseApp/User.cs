using System;
namespace WaereHouseApp
{
    public class User
    {
        //set auto properties
        public string Name { get; set; }
        public string Password { get; set; }

        //the constructor
        public User(string name, string password)
        {
            //set variables
            Name = name;
            Password = password;
        }

        //Method to lof in user
        public static bool Login(User user)
        {
            //clear console
            Console.Clear();

            UI.Header("Sign In");



            //ask for username
            Console.Write("Username: _");
            //get username
            string username = Console.ReadLine();

            //validate password
            Validation.ValidateString(username, "this cant be left blank", "Username: _");

            //ask for password
            Console.Write("Password: _");
            //get password
            string password = Console.ReadLine();

            //validate password
            Validation.ValidateString(password, "this cant be left blank", "Password: _");


            //check if password ans user id match the default 

            if (password == user.Password && username == user.Name)
            {
                //counsole out if true and return true
                Console.WriteLine("\r\nUser Found");
                return true;
            }
            else
            {
                //if it doesnt match console out error return false
                Console.WriteLine("\r\nUser login not recognized");
                return false;
            }
        }
    }
}

