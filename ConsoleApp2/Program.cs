using ConsoleApp2;
using System.Globalization;





while (true)
{

    int choice = Menu.make_menu("Polindrom", "Second Biggest In Array", "Fibonacci", "Unique Symbol", "Exit");
    Console.Clear();
    if (choice == 0)
    {
        Console.Write("Enter A number: ");
        var a = Console.ReadLine();
        Practics.IsPalindrome(a);
        Console.ReadLine();
    }
    else if (choice == 1)
    {
        Console.Write("How many numbers do you have in you array?");
        int n = int.Parse(Console.ReadLine());
        int[] ary = new int[n];

        for (global::System.Int32 i = 0; i < n; i++)
        {
            int entr = int.Parse(Console.ReadLine());
            ary[i] = entr;
        }
        Practics.SecondLargeArray(ary);
        Console.ReadLine();
    }
    else if (choice == 2)
    {
        Console.Write("Enter A number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(Practics.FibonacciNum(num));
        Console.ReadLine();
    }
    else if (choice == 3)
    {
        string name = Console.ReadLine();
        Practics.FindUnique(name);
        Console.ReadLine();
    }
    else if (choice == 4)
    {
        break;
    }

}
