internal class Program
{
    private static void Main(string[] args)
    {
        DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("E. Europe Standard Time"));
        var today = DateTime.Now;
        Console.WriteLine("Tietokoneen päivämäärä ja aika " + today);
        string muutettu = currentTime.ToString("dd.MM.yyyy hh:mm");
        Console.WriteLine("Tietokoneen aika muutettuna suomen aikavyöhykkeeseen: " + muutettu);
    }
}