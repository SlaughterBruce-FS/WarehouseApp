using System;
namespace WaereHouseApp
{
    public class App
    {
        private Menu _menu;
        private bool _loggedIn = false;
        private bool _keepgoing = true;

        public App()
        {

            _keepgoing = true;
            while (_keepgoing)
            {
                if (!_loggedIn)
                {
                    Menu _menu = new();
                    //add values to menu
                    _menu.Init("Main Menu", new string[] { "Create User", "Login", "About", "Exit" });
                    //display menu
                    _menu.Display();
                }
                else
                {
                    Menu _menu = new();
                    //add values to menu
                    _menu.Init($"Welcome jade", new string[] { "About", "Show Items", "Add Item", "Logut", "Exit" });
                    //display menu
                    _menu.Display();
                }


                //call selcetion method and pass down the main user
                Selection();
            }
        }


        private void Selection()
        {
            if (_loggedIn)
            {
                Console.WriteLine("user logged in");
            }
            else
            {
                //choose menu item
                Console.Write("Please Choose a menu option: ");
                string UserPickStr = Console.ReadLine();

                int userPick;

                Validation.ValidateIntMaxMin(UserPickStr, out userPick, "Please only choose a number from the list above.", "Please Choose a menu option: ", 4, 1);

                switch (userPick)
                {
                    case 1:
                        Console.WriteLine("create user");
                        UI.Footer("press any key to continue");
                        break;
                    case 2:
                        Console.WriteLine("Log in");
                        UI.Footer("press any key to continue");
                        break;
                    case 3:
                        Console.WriteLine("about");
                        UI.Footer("press any key to continue");
                        break;
                    case 4:
                        Console.WriteLine("exit");
                        UI.Footer("press any key to continue");
                        break;
                }

            }
        }
    }
}

