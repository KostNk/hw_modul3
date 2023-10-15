using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {

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