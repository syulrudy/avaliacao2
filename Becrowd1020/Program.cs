using System;

class URI
{

    static void Main(string[] args)
    {
        int Dias = Convert.ToInt32(Console.ReadLine());
        int Anos;
        int Meses;
        Anos = Dias / 365;
        Console.WriteLine(Anos + " ano(s)");
        Dias = Dias % 365;
        Meses = Dias / 30;
        Console.WriteLine(Meses + " mes(es)");
        Dias = Dias % 30;        
        Console.WriteLine(Dias + " dia(s)");

    }

}