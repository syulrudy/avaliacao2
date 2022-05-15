using System;

class URI
{

    static void Main(string[] args)
    {               
        string[] Dados = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(Dados[0]);
        int B = Convert.ToInt32(Dados[1]);
        int C = Convert.ToInt32(Dados[2]);
        int MaiorAB = (A + B + Math.Abs(A - B)) / 2;
        int QualMaior = (C + MaiorAB + Math.Abs(C - MaiorAB)) / 2;
        Console.WriteLine(QualMaior + " eh o maior");

        Console.ReadKey();

    }

}