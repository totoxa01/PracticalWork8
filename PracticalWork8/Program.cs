using System;
using MyClassLibrary;

namespace PracticalWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();
            Console.WriteLine(ClassMessage.MethodGreeting(name));
            Console.ReadKey();
        }
    }
}
