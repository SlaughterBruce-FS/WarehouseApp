using System;
namespace WaereHouseApp
{
    public class UI
    {
        public UI()
        {
        }

        //header method 
        public static void Header(string title)
        {
            Console.WriteLine("==========================");
            Console.WriteLine(title.ToUpper());
            Console.WriteLine("==========================\r\n");
        }

        //seperator method
        public static void Separator()
        {
            Console.WriteLine("-----------------------\r\n");
        }

        //footer method
        public static void Footer(string footerText)
        {
            Console.WriteLine("\r\n==========================");
            Console.Write(footerText.ToUpper());
            Console.ReadLine();

        }
    }
}

