using System;
class URI
{
    static void Main(string[] args)
    {

        string entrada;
        while ((entrada = Console.ReadLine()) != null)
        {
            int maiusculasMinusculas = 1;

            foreach (char i in entrada)
            {
                if (maiusculasMinusculas % 2 != 0)
                {
                    if (char.IsWhiteSpace(i))
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(char.ToUpper(i));
                        maiusculasMinusculas++;
                    }
                }
                else if (maiusculasMinusculas % 2 == 0)
                {
                    if (char.IsWhiteSpace(i))
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(char.ToLower(i));
                        maiusculasMinusculas++;
                    }
                }

            }
            Console.Write("\n");
            Console.ReadKey();
        }

    }
}

