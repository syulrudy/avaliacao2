using System;
using System.Globalization;
class URI
{
    static void Main(string[] args)
    {
      int Valor_Digitado = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine(Valor_Digitado);
        int Nota_Quantidade = (Valor_Digitado / 100);
        Console.WriteLine(Nota_Quantidade + " nota(s) de R$ 100,00"); 
        Valor_Digitado = Valor_Digitado % 100;

        Nota_Quantidade = (Valor_Digitado / 50);
        Console.WriteLine(Nota_Quantidade + " nota(s) de R$ 50,00");
        Valor_Digitado = Valor_Digitado % 50;

        Nota_Quantidade = (Valor_Digitado / 20);
        Console.WriteLine(Nota_Quantidade + " nota(s) de R$ 20,00");
        Valor_Digitado = Valor_Digitado % 20;

        Nota_Quantidade = (Valor_Digitado / 10);
        Console.WriteLine(Nota_Quantidade + " nota(s) de R$ 10,00");
        Valor_Digitado = Valor_Digitado % 10;

        Nota_Quantidade = (Valor_Digitado / 5);
        Console.WriteLine(Nota_Quantidade + " nota(s) de R$ 5,00");
        Valor_Digitado = Valor_Digitado % 5;

        Nota_Quantidade = (Valor_Digitado / 2);
        Console.WriteLine(Nota_Quantidade + " nota(s) de R$ 2,00");
        Valor_Digitado = Valor_Digitado % 2;

        Nota_Quantidade = (Valor_Digitado / 1);
        Console.WriteLine(Nota_Quantidade + " nota(s) de R$ 1,00");
    }

}