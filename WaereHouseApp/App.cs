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
            UI.Footer("Press any Button to continue!");
        }
    }
}

