using System;

namespace Q2_listaNinja
{
    class Program
    {
        static void Main (string[] args)
        {
            float[] p1 = new float[2];
            float[] p2 = new float[2];
            Console.WriteLine ("Dgite os valores do primeiro ponto");
            for (int i = 0; i < 2; i++)
            {
                if (i is 0)
                {
                    System.Console.Write ("Dgite o valor de X: ");
                    p1[i] = int.Parse (Console.ReadLine ());
                }
                else
                {
                    System.Console.Write ("Dgite o valor de Y: ");
                    p1[i] = int.Parse (Console.ReadLine ());
                }
            }

            Console.WriteLine ("Dgite os valores do segundo ponto");
            for (int i = 0; i < 2; i++)
            {
                if (i is 0)
                {
                    System.Console.Write ("Dgite o valor de X: ");
                    p2[i] = int.Parse (Console.ReadLine ());
                }
                else
                {
                    System.Console.Write ("Dgite o valor de Y: ");
                    p2[i] = int.Parse (Console.ReadLine ());
                }
            }

            Console.WriteLine ($"resultado: {CalcularDistancia(p1, p2)}");
            Console.ReadLine ();
        }
        static float CalcularDistancia (float[] p1, float[] p2)
        {
            return MathF.Sqrt (MathF.Pow ((p2[0] - p1[0]), 2) + MathF.Pow ((p2[0] - p1[0]), 2));
        }
    }
}