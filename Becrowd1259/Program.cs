using System;
using System.Linq;
class URI
{

    static void Main(string[] args)
    {
        int qtdEntrada = Convert.ToInt32(Console.ReadLine());

        int[] numDigitado = new int[qtdEntrada];
        if (qtdEntrada != 0)
        {
            for (int i = 0; i < numDigitado.Length; i++)
            {
                numDigitado[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in numDigitado.OrderBy(item => item))
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
                
            }
            foreach (var item in numDigitado.OrderByDescending(item => item))
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                }
            }

        }

    }

}