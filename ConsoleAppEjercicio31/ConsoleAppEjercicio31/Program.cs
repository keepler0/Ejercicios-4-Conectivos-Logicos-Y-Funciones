using System;

namespace ConsoleAppEjercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio31AnioBisiestoONo";
            Console.WriteLine("Se determinara si el año ingresado es Bisiesto o no.");
            Console.Write("Inserte el año: ");
            var anio = int.Parse(Console.ReadLine());
            if (verifBisiesto(anio))
            {
                Console.WriteLine($"{anio} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"{anio} no es bisiesto.");
            }
        }

        private static bool verifBisiesto(int anio)
        {
            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
