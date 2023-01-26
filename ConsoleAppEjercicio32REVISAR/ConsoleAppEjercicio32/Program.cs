using System;

namespace ConsoleAppEjercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            //definicion de la variable
            int mes;
            //titulacion del programa
            Console.Title = "Ejercicio32EscribirMesEinformaraCantDias";
            Console.WriteLine("Se seleccionará un mes y se informará la cantidad de dias.");
            Console.Write("Seleccione el mes: ");
            //mes =int.Parse(Console.ReadLine());
            do
            {
                mes = int.Parse(Console.ReadLine());
                if (mes > 0 && mes < 13)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Debe introducir del 1 al 12 de los meses correspondientes");
                }
            } while (!(mes < 13 && mes > 0));
            //if ((mes > 0) && (mes < 13))
            //{
                if (mes==1)
                {
                    Console.WriteLine("Enero tiene 31 dias");
                }
                else 
                {
                    if (mes == 2)
                    {
                        Console.WriteLine("Febrero tiene 28 dias");
                    }
                    else
                    {
                        if (mes == 3)
                        {
                            Console.WriteLine("Marzo tiene 31 dias");
                        }
                        else
                        {
                            if (mes== 4)
                            {
                                Console.WriteLine("Abril tiene 30 dias");
                            }
                            else
                            {
                                if (mes == 5)
                                {
                                    Console.WriteLine("Mayo tiene 31 dias");
                                }
                                else
                                {
                                    if (mes == 6)
                                    {
                                        Console.WriteLine("Junio tiene 30 dias");
                                    }
                                    else
                                    {
                                        if (mes == 7)
                                        {
                                            Console.WriteLine("Julio tiene 31 dias");
                                        }
                                        else
                                        {
                                            if (mes == 8)
                                            {
                                                Console.WriteLine("Agosto tiene 31 dias");
                                            }
                                            else
                                            {
                                                if (mes == 9)
                                                {
                                                    Console.WriteLine("Septiembre tiene 30 dias");
                                                }
                                                else
                                                {
                                                    if (mes == 10)
                                                    {
                                                        Console.WriteLine("Octubre tiene 31 dias");
                                                    }
                                                    else
                                                    {
                                                        if (mes == 11)
                                                        {
                                                            Console.WriteLine("Noviembre tiene 30 dias");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Diciembre tiene 31 dias");
                                                        }
                                                    }
                                                        
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            //}
            //else
            //{
            //  Console.WriteLine("Mes no contemplada");
            //}

        }
    }
}
