using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            string capital, taxa, tempo;

            Console.WriteLine(" ");
            Console.WriteLine(@"Olá usuário!
Bem vindo a este calculador de juros simples! ");
            Console.WriteLine(" ");

            Console.Write("Juros ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Simples ");
            Console.ResetColor();
            Console.WriteLine("(j)");
            Console.WriteLine(" ");

            Console.Write("Capital [c] (R$).......: ");
            capital = Console.ReadLine();
            
            Console.Write("Taxa de juros [i] (%)..: ");
            taxa = Console.ReadLine();
            
            Console.Write("Tempo [t] (meses)......: ");
            tempo = Console.ReadLine();
            Console.WriteLine(" ");

            double c = Convert.ToDouble(capital);
            double i = Convert.ToDouble(taxa);
            double t = Convert.ToDouble(tempo);

            double j = c * i * t;
            double m = c + j;

            Console.WriteLine($"Juros (R$).....: {j:C}");
            Console.WriteLine($"Montante (R$)..: {m:C}");
        }
    }
}
