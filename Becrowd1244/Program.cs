using System;
using System.Collections.Generic;
class URI
{

    static void Main(string[] args)
    {
        string numCasos = Console.ReadLine();

        for (int i = 0; i < int.Parse(numCasos); i++) 
        {
            string casos = Console.ReadLine();
            string[] casosString = casos.Split(' ');

            List<string> listaCasos = new List<string>();
            for (int j = 0; j < casosString.Length; j++)
            {
                listaCasos.Add(casosString[j]);
            //Console.WriteLine(casosString[j]);
            }
            while(listaCasos.Count != 0)
            {
                string maiorString = "";
                foreach (string str in listaCasos)
                    if(str.Length > maiorString.Length) 
                    {
                        maiorString = str;
                    }

                Console.Write(maiorString.Trim());
                if (listaCasos.Contains(maiorString))
                { 
                    listaCasos.Remove(maiorString);
                }


                if(listaCasos.Count > 0)
                {
                    Console.Write(" ");
                }
                
            }
            Console.WriteLine("");
        }

    }

}
