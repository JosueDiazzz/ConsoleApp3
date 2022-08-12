using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero a procesar");
            int multiplo = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el limite");
            int limite = int. (Console.ReadLine());

            for (int i =0; i <= limite; i++)
            { 
                if (i %multiplo == 0)
                {
                    Console.Write(i + "");
        }
    }
}
