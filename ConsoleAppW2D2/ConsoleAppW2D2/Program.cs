// See https://aka.ms/new-console-template for more information
using ConsoleAppW2D2.Models;

Console.WriteLine("Hello, World!");

var Curriculum = new Curriculum();

var Info = new Curriculum.Informazioni_Personali();

Console.WriteLine("Scrivi il Tuo Nome");

Info.Nome = Console.ReadLine();

Console.WriteLine("Scrivi il Tuo Cognome");

Info.Cognome = Console.ReadLine();

Console.WriteLine("Digita il tuo numero(+39 gia incluso)");

Info.Telefono =

