using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Menu
    {

        public static int make_menu(params string[] arr)
        {
            int index = 0;


            dynamic choice;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.SetCursorPosition(50, 12 + i);
                    if (index == i)
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(arr[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                choice = Console.ReadKey();
                if (index == 0 && choice.Key == ConsoleKey.UpArrow)
                {
                    index = arr.Length - 1;
                }
                else if (choice.Key == ConsoleKey.UpArrow)
                {
                    index--;
                }
                else if (index == arr.Length - 1 && choice.Key == ConsoleKey.DownArrow)
                {
                    index = 0;
                }
                else if (choice.Key == ConsoleKey.DownArrow)
                {
                    index++;
                }
                else if (choice.Key == ConsoleKey.Enter) return index;
            }

        }

        
        

    }
}
