using System;

namespace ConsoleAppEjercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio30IngresarTresNumYOdenarDeMayAMen";
            Console.WriteLine("Se ingresará tres números y se ordenará de Mayor a Menor");
            Console.WriteLine("Ingrese los números");
            Console.Write("Primer número: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            var num2 = int.Parse(Console.ReadLine());
            Console.Write("Tercer número: ");
            var num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Se ingresó: {num1} , {num2} , {num3}.");
            int func;
            func = verificarOrden(num1, num2, num3);
        }

        private static int verificarOrden(int num1, int num2, int num3)
        {
			int mayor, medio, menor;
			int orden=0;
			if (num1 > num2)
			{
				if (num1 > num3)
				{
					mayor = num1;
					if (num2 > num3)
					{
						medio = num2;
						menor = num3;
					}
					else
					{
						medio = num3;
						menor = num2;
					}
				}
				else
				{
					mayor = num3;
					medio = num1;
					menor = num2;
				}
			}
			else
			{
				if (num2 > num3)
				{
					mayor = num2;
					if (num1 > num3)
					{
						medio = num1;
						menor = num3;
					}
					else
					{
						medio = num3;
						menor = num1;
					}
				}
				else
				{
					mayor = num3;
					medio = num2;
					menor = num1;
				}
			}
		Console.WriteLine($"Mayor a Menor: { mayor} , {medio} ,  {menor}");
		return orden;
		}
    }
}
