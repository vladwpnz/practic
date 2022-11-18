using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> charsList = new List<char>();

            Console.WriteLine("добавьте буквы в лист (просто нажимайте буквы), для продолжения нажмите Enter:");

            ConsoleKey exit;
            while ((exit = Console.ReadKey(true).Key) != ConsoleKey.Enter)
            {
                charsList.Add((char)exit);
                Console.Write(exit.ToString().ToLower() + " ");
            }


            Console.WriteLine();

            Console.Write("Выберите какой буквы хотите узнать индекс: ");

            char a = (char)Console.ReadKey().Key;

            Console.WriteLine();

            Console.WriteLine("индексы:");


            for (int i = 0; i < charsList.Count; i++) 

                if (charsList[i] == a) Console.Write(i + " ");



            char[] arr = charsList.ToArray();

            Console.ReadKey(true);
        }
    }
}
