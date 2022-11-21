using System;
namespace WaereHouseApp
{
    public class Menu
    {
        //declare private fields
        private string _title;
        private List<string> _menuItems = new List<string>();

        public Menu()
        {
        }

        //init method that accepts string for tittl and a array of strings
        public void Init(string title, string[] items)
        {
            //set title
            _title = title;

            //for loop to add each element to the list
            for (int j = 0; j < items.Length; j++)
            {
                //add to list
                _menuItems.Add(items[j]);
                //Console.WriteLine(items[j]);
            }

        }

        //start display method
        public void Display()
        {
            //display header
            UI.Header(_title);

            //start for loop to display each item in the list
            for (int i = 0; i < _menuItems.Count; i++)
            {
                //console out a number and the name from the list
                Console.WriteLine($"[{i + 1}] {_menuItems[i]}");
            }
        }

    }
}

