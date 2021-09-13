using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Informe os dados abaixo para o calculo do juros---\n");

            Console.Write("\nCapital: ");
            double Capital = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nTaxa do Juros: ");
            double Taxa = Convert.ToDouble(Console.ReadLine());

            Taxa = Taxa / 100;

            Console.Write("\nTempo: ");
            double Tempo = Convert.ToDouble(Console.ReadLine());

            double Juros = Taxa * Capital * Tempo; 

            Console.WriteLine($"\nJuros R$ = {Juros:N2}");

            double Montante = Capital + Juros;

            Console.WriteLine($"Montante R$ = {Montante:N2}\n");
            
        }
    }
}
