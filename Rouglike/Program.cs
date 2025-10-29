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
            imię = "Paziu";
            Console.WriteLine($"Będę Cię w takim razie nazywał {imię}...");
        }
        
        
        Console.WriteLine($"Skąd jesteś {imię}?");
        var miejsce = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(miejsce))
        {
            Console.WriteLine("Nie jesteś typem gaduły");
            miejsce = "Nikąd";
        }
        Console.WriteLine($"Witaj cichy {imię} z {miejsce}.");
        
        Console.WriteLine();
        Console.WriteLine("Naciśnij dowolny klawisz żeby zakończyć...");
        Console.ReadKey();
    }
}