using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Fase 1");
            string nombre = " Jordan ";
            string apellido1 = "Bailon ";
            string apellido2 = "Cercado";
            Console.WriteLine(apellido1 + apellido2 + nombre);
            int dia = 18;
            int mes = 6;
            int año = 1997;
            Console.WriteLine(dia + "/" + mes+ "/" + año);
            */
            Console.WriteLine("Fase 2");
            const int bisiesto = 1948;
            const int intervaloAños = 4;
            int añoNacimiento = 1997;
            int resultado = (añoNacimiento - bisiesto) / intervaloAños;
            Console.WriteLine("Hay " + resultado + " años bisiestos entre " + bisiesto + " y " + añoNacimiento);



            /*ATENCIO! Haureu de canviar el tipus de variable de l’any 1948 per poder modificar-la.  

            Creeu una variable bool que sera certa si l’any de naixement és de traspàs o falsa si no ho és. 

            En cas de que la variable bool sigui certa, heu de mostrar per consola una frase on ho digui, en cas de ser falsa mostrareu la frase pertinent.
            Creeu dues variables string per guardar les frases.  

            Creeu una variable on juntareu el nom i els cognoms (tot en una variable) i un altre on juntareu la data de naixement separada per “/” (tot en una variable). 
            Mostreu per consola les variables del nom complet, la data de naixement i si l’any de naixement es de traspàs o no.*/


            Console.WriteLine("Fase 3");
            string fullName = "Jordan Fernando Bailon Cercado";
            string fechaNacimiento = "18 / 06 / 1997";

            //La variable añoInicio se usa en dentro del bucle que está comentado en la línea 58.

            var añoInicio = bisiesto;
            string fraseTrue = " es un año bisiesto";
            string fraseFalse = " no es un año bisiesto";
            Console.WriteLine("Mi nombre es " + fullName);
            Console.WriteLine("Nací el " + fechaNacimiento);
            if (añoNacimiento % 4 == 0)
            {
                Console.WriteLine("Mi año de nacimiento" + fraseTrue);
            }else if (añoNacimiento % 4 != 0)
            {
                Console.WriteLine("Mi año de nacimiento" + fraseFalse);
            }

            //Partint de l’any 1948 heu de fer un bucle for i mostrar els anys de traspàs fins arriba al vostre any de naixement.  
            /*for (int i = añoInicio; i <= añoNacimiento; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i + fraseTrue);
                }else if (i % 4 != 0)
                {
                    Console.WriteLine(i + fraseFalse);
                }
            }*/
        }
    }
}
