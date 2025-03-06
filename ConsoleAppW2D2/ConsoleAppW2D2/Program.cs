// See https://aka.ms/new-console-template for more information
using ConsoleAppW2D2.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var Curriculum = new Curriculum();

        var Info = new Curriculum.Informazioni_Personali();

        Console.WriteLine("Scrivi il Tuo Nome");

        Info.Nome = Console.ReadLine();

        Console.WriteLine("Scrivi il Tuo Cognome");

        Info.Cognome = Console.ReadLine();

        Console.WriteLine("Scrivi la tua mail");

        Info.Email = Console.ReadLine();

        Console.WriteLine("Digita il tuo numero(+39 gia incluso)");

        Info.Telefono = 



        Console.WriteLine($"CV di {Info.Nome} {Info.Cognome}");
        Console.WriteLine("");
        Console.WriteLine("++++ INIZIO Informazioni Personali: ++++");
        Console.WriteLine($"Nome:{Info.Nome}");
        Console.WriteLine($"Cognome:{Info.Cognome}");
        Console.WriteLine($"Email:{}");
        Console.WriteLine($"Telefono: +39{Info.Telefono}");

    }
}