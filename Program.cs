using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal Altura, Peso;
            string sexo;

            Console.Write("Digite sua Altura em m....: ");

            if (!Decimal.TryParse(Console.ReadLine(), out Altura) || Altura >=3 || Altura <=0)
            {
                Console.WriteLine("\n\nERROR: A Altura não é um número valido. Tente novamente.");
                Environment.Exit(1);
            }        

            Console.Write("Sexo [M]asculino / [F]eminino...: ");
            sexo = Console.ReadLine();

            switch (sexo.ToUpper())
            {
                case "M":
                    Peso = Altura * 72.7m - 58.0m;
                    Console.Write($"\nSeu peso ideal é {Peso:N1}kg.");
                    break;
                case "F":
                    Peso = Altura * 62.1m - 44.7m;
                    Console.Write($"\nSeu peso ideal é {Peso:N1}kg.");
                    break;
                default:
                    Console.Write($"\nERROR: O Peso informado não é valido. {sexo} ");
                    break;
            }
        }
    }
}
