using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContadorPalabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Debe contar las palabras que contiene la cadena

            string cadena = "    Hola, soy una cadena     con varias palabras    ";

            int contador = 0;

            cadena = Regex.Replace(cadena,@"\s+", " ").Trim();

            var words = cadena.Split(' ');

            contador = words.Length;

            Console.WriteLine(contador);
        }
    }
}
