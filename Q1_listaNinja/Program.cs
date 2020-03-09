using System;

namespace _Q1_listaNinja
{
    class Program
    {
        static void Main (string[] args)
        {
            System.Console.Write ("Dgite qunatas horas de viajem: ");
            int tempo = int.Parse (Console.ReadLine ());

            System.Console.Write ("Digite a velociade media: ");
            float VelociadeMedia = float.Parse (Console.ReadLine ());

            Console.WriteLine ($"Gasolina necessaria: {GasolinaNecessaria (tempo, VelociadeMedia)}");
            Console.ReadLine ();
        }

        static float GasolinaNecessaria (int tempo, float VelociadeMedia, int KmL = 12) => ((tempo * VelociadeMedia) / KmL);

    }
}