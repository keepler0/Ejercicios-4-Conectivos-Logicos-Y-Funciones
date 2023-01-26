using System;

namespace ConsoleAppEjercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio36DosLadosDeUnCuadrilatero";
            //definicion de las variables
            int perimetro, superficie;
            Console.WriteLine("Se informara (Segun sus lados introducidos), si es un cuadrado o un rectangulo");
            Console.WriteLine("Inserte los lados");
            Console.Write("Primer lado: ");
            var lado1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo lado: ");
            var lado2 = int.Parse(Console.ReadLine());
            if (verLados(lado1, lado2))
            {
                Console.WriteLine($"El cuadrilatero con el Primer lado:{lado1} y Segundo lado:{lado2} forman un cuadrado");
            }
            else
            {
                Console.WriteLine($"El cuadrilatero con el Primer lado:{lado1} y Segundo lado:{lado2} forman un rectangulo");
            }
            perimetro = (2 * lado1) + (2 * lado2);
            Console.WriteLine($"{perimetro} es su perimetro");
            superficie = lado1 * lado2;
            Console.WriteLine($"{superficie} es su superficie");
        }

        private static bool verLados(int lado1, int lado2)
        {
            if (lado1 == lado2)
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
