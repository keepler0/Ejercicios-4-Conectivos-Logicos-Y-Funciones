using System;

namespace ConsoleAppEjercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 26 la letra es vocal o no?";
            Console.WriteLine("Se verificara si la letra insertada es vocal o no");
            var vocales = "aAeEiIoOuU";
            Console.Write("Ingrese una letra: ");
            char letra = Console.ReadKey().KeyChar;
            Console.WriteLine();

            //existen 3 formas para obtener el resultado

            //**********************METODO CON IndexOf***************************
            //IdexOf verifica en la variable en que posicion se situa al ser verdadero va a ser >=0 caso falso -1
            if (vocales.IndexOf(letra) >= 0)
            {
                Console.WriteLine($"{letra} es una vocal y esta en la posicion {vocales.IndexOf(letra)}");
            }
            else
            {
                Console.WriteLine($"{letra} no es una vocal");
            }

            //**************METODO CONTAINS**************************
            //Conteins verifica en la Var si contiene el char o string dara verdadero o falso si no lo contiene
            if (vocales.Contains(letra))
            {
                Console.WriteLine($"{letra} es una vocal");
            }
            else
            {
                Console.WriteLine($"{letra} no es una vocal");
                

                


                //y por ultimo usar los conectores logicos como || o && pero este hace a la estructura mucho mas larga por lo tanto para simploficar se usa los anteriormente mencionados
            }
            ////}
            //**************METODO CON CONECTORES LOGICOS**********************
            //usar los conectores logicos como || (or) o && (and) pero este hace a la estructura mucho mas larga por lo tanto para simploficar se usa los anteriormente mencionados
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Console.WriteLine($"{letra} es una vocal");
            }
            else
            {
                Console.WriteLine($"{letra} no es una vocal");
            }

        }
    }
}
