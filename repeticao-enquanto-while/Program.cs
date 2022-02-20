using System;
using System.Globalization;

namespace repeticao_enquanto_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero para saber a raiz   ");

            double y = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            double raiz = Math.Sqrt(y);
            while(y <= 0.0 || y > 0.0)
            {
                while (y >= 0.0)
                {
                    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                    Console.Write("Digite outro numero   ");
                    y = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    raiz = Math.Sqrt(y);
                }

                while (y < 0.0)
                {
                    Console.WriteLine("Raiz quadrade de numero negativo não existe");
                    Console.Write("Digite outro numero   ");
                    y = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    raiz = Math.Sqrt(y);
                }
            }

        }
    }
}
