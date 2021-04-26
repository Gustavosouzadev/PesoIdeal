using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string M;
            double Altura;
            double PesoM;
            double PesoF;

            Console.WriteLine("-----Vamos Conferir Seu Peso.-----\n");

            Console.Write("Digite sua altura em m..........:");
            Altura = Convert.ToDouble (Console.ReadLine());

            Console.Write("Sexo [M]asculino / [F]eminino...:");
            M = Console.ReadLine().ToUpper();

            PesoM = (Altura) * (72.7) - (58.0);
            PesoF = (Altura) * (62.1) - (44.7);

            switch (M)
            {
                case "M":
                    Console.WriteLine($"\nSeu peso ideal é {PesoM:N1}kg.");
                    break;
                case "F":
                    Console.WriteLine($"\nSeu peso ideal é {PesoF:N1}kg.");
                    break;
            }
    
        }
    }
}
