internal class Program
{
    private static void Main(string[] args)
    {
        DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("E. Europe Standard Time"));
        var today = DateTime.Now;
        Console.WriteLine("Tietokoneen päivämäärä ja aika " + today);
        Console.WriteLine("Tietokoneen aika muutettuna suomen ajaksi: " + currentTime);
    }
}