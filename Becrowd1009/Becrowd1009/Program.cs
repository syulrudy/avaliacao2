using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        string Nome = System.Console.ReadLine();
        double SalarioFixo = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
        double TotalVendas = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

        double SalarioFinal = (TotalVendas * 0.15) + SalarioFixo;
        Console.WriteLine("TOTAL = R$ {0}", SalarioFinal.ToString("F2", CultureInfo.InvariantCulture));

        Console.ReadKey();

    }

}