using System;

class Program
{
    static void Main()
    {

        //założenia
        int begin, end;


        Console.WriteLine("Witaj w programie do wyszukiwania licz parzystych z podanego zakresu \npodaj początek zakresu...");
        begin = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj koniec zakresu");
        end = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Liczby parzyste podanego zakresu to:");

        do
        {
            
            if (begin % 2 == 0)
            {
                Console.WriteLine(begin);
            }
            begin++;
        }
        while (begin < end);
        
       

    }
}