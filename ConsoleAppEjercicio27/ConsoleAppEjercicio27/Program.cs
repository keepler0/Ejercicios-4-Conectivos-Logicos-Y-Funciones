using System;

namespace ConsoleAppEjercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio27EsParOImpar";
            //mensaje para el usuario
            Console.WriteLine("Se informará si el numero ingresado es par y positivo");
            Console.Write("Inserte un numero: ");
            //definicion de la variable e imput key para definir el valor a calcular
            var num = int.Parse(Console.ReadLine());
            //proceso del programa
            //anidamiento de bifurcaciones
            if (num >= 0)
            {
                if (verificarPar(num))
                {
                    Console.WriteLine($"El numero {num} es par y positivo");
                }
                else
                {
                    Console.WriteLine($"El numero {num} es impar y positivo");
                }
            }
            else
            {
                if (verificarPar(num))
                {
                    Console.WriteLine($"El numero {num} es par y negativo");
                }
                else
                {
                    Console.WriteLine($"El numero {num} es impar y negativo");
                }
            }
            //fin del programa y muestra de la informacion
        }

        private static bool verificarPar(int num) => num % 2 == 0;
    }
}
