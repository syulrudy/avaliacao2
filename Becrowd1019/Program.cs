using System;

class URI
{

    static void Main(string[] args)
    {
        int Segundos = Convert.ToInt32(Console.ReadLine());

        int Hora = Segundos / 3600;
        Segundos = Segundos % 3600;
        
        int Minutos = Segundos / 60;
        Segundos = Segundos % 60;
        
        Console.WriteLine(Hora+ ":"+Minutos+":"+Segundos);
        

    }

}