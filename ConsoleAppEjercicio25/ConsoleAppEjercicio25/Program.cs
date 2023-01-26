using System;

namespace ConsoleAppEjercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio 25 multiplo de 2 y 3 a la vez?";
            Console.WriteLine("se verificara si el numero ingresado es multiplo de 2 y 3 a la vez");
            //definicion del valor a calcular y definicion de la variable
            Console.Write("Ingrese un numero: ");
            var num = int.Parse(Console.ReadLine());
            //proceso del programa
            if ((multiploDeDos(num)) && (multiploDeTres(num)))
            {
                Console.WriteLine($"El numero: {num} es multiplo de 2 y 3 a la vez.");
            }
            else
            {
                Console.WriteLine($"El numero: {num} no es multiplo de 2 y 3 a la vez.");
            }
        }
        private static bool multiploDeTres(int num) => num % 3 == 0;

        private static bool multiploDeDos(int num) => num % 2 == 0;
    }
}
