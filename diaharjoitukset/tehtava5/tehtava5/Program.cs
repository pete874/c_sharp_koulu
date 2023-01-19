internal class Program
{
    private static void Main(string[] args)
    {
        //kysytään käyttäjältä, minkä seuraavista kolmesta vaihtoehdosta hän haluaa syöttää
        Console.WriteLine("Haluatko antaa kokonaisluvun, double-luvun vai merkkijonon: ");
        string luku = Console.ReadLine();

        
        // tehdään switch case syötettyä vaihtoehtoa varten.
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
                double doubleLuku = Double.Parse(Console.ReadLine());
                doubleLuku++;
                Console.WriteLine(doubleLuku);
                break;

            case "merkkijonon":
                Console.WriteLine("Anna merkkijono: ");
                string merkkijono = Console.ReadLine();
                Console.WriteLine(merkkijono + "*");
                break;

            default:
                Console.WriteLine("Väärä syöte");
                break;
        }
    }
}