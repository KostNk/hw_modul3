using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Введите ваш любимый цвет");

        var color = Console.ReadLine();

        if (color == "red")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is red!");
        }

        else if (color == "green")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is green!");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is cyan!");
        }

        Console.WriteLine("Как Вас зовут?");
        var Name = Console.ReadLine();

        Console.WriteLine("Сколько вам лет?");
        var age = checked((byte)int.Parse(Console.ReadLine()));

        Console.WriteLine("Какая ваша дата рождения?");
        var dateBirth = Console.ReadLine();

        Console.WriteLine("Вас зовут {0}, Вам {1} лет, Вы родились {2}", Name, age, dateBirth );
        Console.ReadKey();

    }
}