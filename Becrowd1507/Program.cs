using System;
using System.Collections.Generic;
class URI
{

    static void Main(string[] args)
    {

        Console.WriteLine("Número de casos:");
        int num_casos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("String Inicial");
        string stringInicial = Console.ReadLine();
        Dictionary<string, IEnumerable<string>> stringList = new Dictionary<string, IEnumerable<string>>();

        for (int i = 0; i < num_casos; i++)
        {
            Console.WriteLine("Número de Sub-Strings");
            int numStrings = Convert.ToInt32(Console.ReadLine());
            string[] numStringsArray = new string[numStrings];

            for (int j = 0; j < numStrings; j++)
            {
                Console.WriteLine("Substring");
                numStringsArray[j] = Console.ReadLine();
                
            stringList.Add(stringInicial, numStringsArray);
            }

        
            Console.WriteLine();
        }
        foreach (var item in stringList)
        {
            foreach (var item2 in item.Value)
            {
                
                Console.WriteLine(isSubString(item.Key, item2) ? "Yes" : "No");
            }
            
        }
    }

    private static bool isSubString(string subString, string entrada)
    {
        Int64 indexSubstring = subString.Length;
        Int64 indexEntrada = entrada.Length;
        Int32 i, j;
        for (i = 0, j = 0; i < indexEntrada && j < indexSubstring; i++)
        {

            if (Convert.ToInt64(subString[j]) == Convert.ToInt64(entrada[i]))
            {
                Console.WriteLine(subString[j]);
                Console.WriteLine(entrada[i]);
                j++;
            }

        }
        if (j == subString.Length)
        {            
            return true;
        }
        else
        {            
            return false;
        }
        
    }

}