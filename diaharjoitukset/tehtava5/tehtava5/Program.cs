internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Haluatko antaa kokonaisluvun, double-luvun vai merkkijonon: ");
        string luku = Console.ReadLine();

        switch(luku)
        {
            case "kokonaisluvun":
                Console.WriteLine("Anna kokonaisluku: ");
                int kokonaisluku = int.Parse(Console.ReadLine());
                kokonaisluku++;
                Console.WriteLine("lisään antamaasi lukuun yhden, lukusi on nyt: " + kokonaisluku);
                break;

            case "double-luvun":
                Console.WriteLine("Anna double-luku: ");
                double doubleLuku = float.Parse(Console.ReadLine());
                Console.WriteLine(doubleLuku);
                break;
        }
    }
}