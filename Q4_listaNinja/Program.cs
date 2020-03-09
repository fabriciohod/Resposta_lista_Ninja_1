using System;

namespace Q4_listaNinja
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write ($"Digite o tempo em segundos: ");
            int tempo = int.Parse (Console.ReadLine ());

            Console.WriteLine (FormatarHorario (tempo));
            Console.ReadLine ();
        }
        static string FormatarHorario (int tempo)
        {
            var horas = tempo / 3600;
            var minutos = (tempo % 3600) / 60;
            var segundos = tempo % 60;

            return $"horas: {horas} minutos: {minutos} segundos: {segundos}";
        }
    }
}