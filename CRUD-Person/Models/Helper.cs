using System;
namespace CRUD_Person.Models
{
    public class Helper
    {
        public void TextColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public void ReturnMenuMessage()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Press a key to return to Menu");
            Console.ReadKey();
            Console.Clear();
        }

       
    }
}

