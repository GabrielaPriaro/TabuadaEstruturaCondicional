//Utilizar estrutura condional For:
//Problema "tabuada"
//Ler um número inteiro N, daí mostrar na tela a tabuada de N para 1 a 10, conforme exemplo. 

using System.Runtime.Versioning;

namespace TabuadaEstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabuada, resultado;

            Console.Write("Deseja a tabuada para qual valor? ");
            tabuada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = tabuada * i;

                Console.WriteLine($"{tabuada} x {i} = {resultado}");
            }
        }
    }
}
