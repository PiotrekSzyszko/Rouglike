namespace Rouglike;

internal static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jak się nazywasz Nieznajomy?");
        var imię = Console.ReadLine();
        
        Console.WriteLine($"Skąd jesteś {imię}?");
        var miejsce = Console.ReadLine();
        Console.WriteLine($"Witaj {imię} z {miejsce}!");
        
        Console.WriteLine("Naciśnij ENTER żeby zakończyć...");
        Console.ReadLine();
    }
}