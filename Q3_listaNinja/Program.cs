using System;

namespace Q3_listaNinja
{
    class Program
    {
        static void Main (string[] args)
        {
            System.Console.Write ("Digite quanto dinheiro: ");
            int dinheiro = int.Parse (Console.ReadLine ());

            Console.WriteLine (DecomporDinheiro (dinheiro));
            Console.ReadLine ();
        }
        static string DecomporDinheiro (int dinheiro)
        {
            var _100 = (dinheiro / 100);
            var _50 = ((dinheiro % 100) / 50);
            var _20 = (((dinheiro % 100) % 50) / 20);
            var _5 = ((((dinheiro % 100) % 50) % 20) / 5);
            var _1 = (((((dinheiro % 100) % 50) % 20) % 5) / 1);

            return $"notas 100: {_100} | notas 50: {_50} | notas 20: {_20} | notas 5: {_5} | notas : {_1}";
        }
    }
}