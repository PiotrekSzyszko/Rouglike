namespace Rouglike;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Jak się nazywasz Nieznajomy?");
        
        var imię = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(imię))
        {
            imię = "Nieznajomy";
            Console.WriteLine($"W takim razie będę nazywał Cię {imię}...");
        }
        else if (imię.ToLower() is  "nieznajomy")
        {
            Console.WriteLine("Wiedziałem, że masz tak na imię!");
        }


        Console.WriteLine($"Skąd jesteś {imię}?");
        var miejsce = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(miejsce))
        {
            Console.WriteLine("Nie jesteś typem gaduły.");
            miejsce = "Nikąd";
        }
        Console.WriteLine($"Witaj {imię} z {miejsce}.");
        
        Console.WriteLine();
        Console.WriteLine("Naciśnij dowolny klawisz żeby zakończyć...");
        Console.ReadKey(true);
    }
}