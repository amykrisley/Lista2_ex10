using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1, P2, MED;

            Console.Write("Digite a 1° nota: ");
            P1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a 2° nota: ");
            P2 = double.Parse(Console.ReadLine());

            MED = (P1 + 2 * P2) / 3;

            if (MED >= 5)
                Console.WriteLine("Média={0}\nAprovado", MED);
            else
                Console.WriteLine("Média={0}\nReprovado", MED);

        }
    }
}
