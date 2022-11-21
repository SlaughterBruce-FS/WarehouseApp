using System;
namespace WaereHouseApp
{
    public class Validation
    {
        public Validation()
        {
        }

        public static string ValidateString(string text, string problem, string question)
        {
            while (string.IsNullOrWhiteSpace(text))
            {
                //tell problem
                Console.WriteLine(problem);
                //reask question
                Console.Write(question);
                //catch response
                text = Console.ReadLine();
            }

            return text;
        }

        public static int ValidateInt(string numberString, out int number, string problem, string question)
        {
            while (!int.TryParse(numberString, out number))
            {
                //tell problem
                Console.WriteLine(problem);
                //re ask question
                Console.Write(question);
                //re get answer
                numberString = Console.ReadLine();
            }
            return number;
        }



        public static bool ValidateRange(int numberToCheck, int min, int max)
        {

            return (numberToCheck >= min && numberToCheck <= max);
        }

        public static int RandomPick(int min, int max)
        {
            //generate random number
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}

