using System;

class Program
{
    static void Main(string[] args)
    {
        // Kommentar: Här ska ny funktionalitet läggas till
        Console.WriteLine("Hej, världen!");
        
        // At göra: Implementera en ny funktion för att räkna till 10
        RäknaTillTio(); // Kalla på funktionen som räknar till 10
    }

    // Ny metod som räknar till 10 och skriver ut varje tal
    static void RäknaTillTio()
    {
        // Loop för att räkna från 1 till 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i); // Skriv ut det aktuella talet
        }
    }
}
