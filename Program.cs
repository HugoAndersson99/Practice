using System;

class Program
{
  
   
    //METOD: Fahr_to_cel konverterar Fahrenheit till Celsius i heltal
    static int fahr_to_cel(int fahrenheit)
    {
        // Subtrahera med 32
        // Multiplicera med 5
        // Dividera med 9
        int celsius = (fahrenheit - 32) * 5 / 9;
        return celsius;
    }

    //METOD: Start på programmet
    static void Main(string[] args)
    {
        //ange grader i fahrenheit
        //Argument
        Console.WriteLine("Skriv in grader i Fahrenheit: ");
        int fahrenheit = Convert.ToInt32(Console.ReadLine());

        //Anropar Metod fahr_to_cel
        //Konvertera till celsius och skriv ut
        int celsius = fahr_to_cel(fahrenheit);
        Console.WriteLine(fahrenheit + " grader Fahrenheit blir " + celsius + " grader Celsius.");
        Console.WriteLine("Tryck ENTER för att avsluta...: "); //För att programmet inte ska avslutas direkt
        Console.ReadKey();
    }
}