using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] Dados_Nota1 = Console.ReadLine().Split(' ');
        int Codigo_Peca1 = Convert.ToInt32(Dados_Nota1[0]);
        int Quantidade_Peca1 = Convert.ToInt32(Dados_Nota1[1]);
        double Valor_Peca1 = Convert.ToDouble(Dados_Nota1[2], CultureInfo.InvariantCulture);

        string[] Dados_Nota2 = Console.ReadLine().Split(' ');
        int Codigo_Peca2 = Convert.ToInt32(Dados_Nota2[0]);
        int Quantidade_Peca2 = Convert.ToInt32(Dados_Nota2[1]);
        double Valor_Peca2 = Convert.ToDouble(Dados_Nota2[2], CultureInfo.InvariantCulture);

        double Valor_Pagar = (Quantidade_Peca1 * Valor_Peca1) + (Quantidade_Peca2 * Valor_Peca2);
        Console.WriteLine("VALOR A PAGAR: R$ "+ Valor_Pagar.ToString("F2", CultureInfo.InvariantCulture));

        Console.ReadKey();


    }

}
