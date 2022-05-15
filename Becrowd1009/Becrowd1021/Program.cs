using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        double Valor,
               Nota_Cem,
               Nota_Cinquenta,
               Nota_Vinte,
               Nota_Dez,
               Nota_Cinco,
               Nota_Dois,
               resto,
               Um_Real,
               Cinquenta_Centavos,
               VinteCinco_Centavos,
               Dez_Centavos,
               Cinco_Centavos,
               Um_Centavo;

        Valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("NOTAS:");

        Nota_Cem = (Valor / 100);
        resto = Valor % 100;
        Console.WriteLine((Int32)(Nota_Cem) + " nota(s) de R$ 100.00");

        Nota_Cinquenta = (resto / 50);
        resto = (resto % 50);
        Console.WriteLine((Int32)(Nota_Cinquenta) + " nota(s) de R$ 50.00");

        Nota_Vinte = (resto / 20);
        resto = resto % 20;

        Console.WriteLine((Int32)(Nota_Vinte) + " nota(s) de R$ 20.00");

        Nota_Dez = (resto / 10);
        resto = resto % 10;
        Console.WriteLine((Int32)(Nota_Dez) + " nota(s) de R$ 10.00");

        Nota_Cinco = (resto / 5);
        resto = resto % 5;
        Console.WriteLine((Int32)(Nota_Cinco) + " nota(s) de R$ 5.00");

        Nota_Dois = (resto / 2);
        resto = resto % 2;
        Console.WriteLine((Int32)(Nota_Dois) + " nota(s) de R$ 2.00");

        Console.WriteLine("MOEDAS:");

        Um_Real = (resto / 1);
        resto = resto % 1;
        Console.WriteLine((Int32)Um_Real + " moeda(s) de R$ 1.00");
        resto = resto * 100;
        Cinquenta_Centavos = (resto / 50);
        resto = resto % 50;
        Console.WriteLine((Int32)Cinquenta_Centavos + " moeda(s) de R$ 0.50");

        VinteCinco_Centavos = (resto / 25);
        resto = resto % 25;
        Console.WriteLine((Int32)VinteCinco_Centavos + " moeda(s) de R$ 0.25");

        Dez_Centavos = (resto / 10);
        resto = resto % 10;
        Console.WriteLine((Int32)Dez_Centavos + " moeda(s) de R$ 0.10");

        Cinco_Centavos = (resto / 05);
        resto = resto % 05;
        Console.WriteLine((Int32)Cinco_Centavos + " moeda(s) de R$ 0.05");

        Um_Centavo = (resto / 01);
        resto = resto % 1;
        Console.WriteLine((Int32)Um_Centavo + " moeda(s) de R$ 0.01");

        Console.ReadKey();
    }

}