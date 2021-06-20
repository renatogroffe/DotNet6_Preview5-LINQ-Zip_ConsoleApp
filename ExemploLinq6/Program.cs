using System;
using System.Linq;

namespace ExemploLinq6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Testes com o método Zip ***");
            Console.WriteLine();

            var numeros = new int[] { 1, 2, 3, 10, 100 };
            var numerosRomanos = new string[] { "I", "II", "III", "X", "C" };
            var descricoes = new string[] { "um", "dois", "três", "dez", "cem" };
            
            var resultados = numeros.Zip(descricoes, numerosRomanos);
            foreach (var resultado in resultados)
                Console.WriteLine(resultado);
        }
    }
}