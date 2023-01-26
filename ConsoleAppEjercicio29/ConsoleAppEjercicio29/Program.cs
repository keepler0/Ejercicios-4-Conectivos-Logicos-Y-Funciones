using System;

namespace ConsoleAppEjercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio29OrdenarLosTresNumeros";
            //mensaje del programa para el usuario
            Console.WriteLine("Se ordenará los siguientes numeros introducidos");
            Console.WriteLine("Inserte los números");
            //definicion de las variables e introduccion de los valores a calcular
            int mayor;
            Console.Write("Primer número: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            var num2 = int.Parse(Console.ReadLine());
            Console.Write("Tercer número: ");
            var num3 = int.Parse(Console.ReadLine());
            //se realizará una funcion para calcular
            mayor = Orden(num1, num2, num3);
            Console.WriteLine("Se ingresó " + num1 + " , " + num2 + " , " + num3);
            Console.WriteLine("El numero: " + mayor + " es el mayor");
        }

        static int Orden(int num1, int num2, int num3)
        {
            int orden;
            if (num1 > num2 && num1 > num3)
            {
                orden = num1;
            }
            else
            {
                if (num2 > num1 && num2 > num3)
                {
                    orden = num2;
                }
                else
                {
                    orden = num3;
                }
            }
            return orden;
        }
    }
}

