using System;

namespace Q5_listaNinja
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] numeros = new int[4];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write ($"Digite um numero [{i}]: ");
                numeros[i] = int.Parse (Console.ReadLine ());
            }
            Console.WriteLine ($"resulatado {Calculo(numeros)}");
            Console.ReadLine ();
        }

        static int Calculo (int[] n) => (n[0] * n[1]) - (n[2] * n[3]);

    }
}