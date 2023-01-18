internal class Program
{
    private static void Main(string[] args)
    {
        //pyydetään käyttäjältä kaksi lukua ja tallennetaan ne muuttujiin

        Console.WriteLine("Anna ensimmäinen luku: ");
        int luku1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Anna toinen luku: ");
        int luku2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Anna kolmas luku: ");
        int luku3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Annoit luvut: " + luku1 +", " + luku2 + ", " + luku3);

        //Tehdään if-lause, jolla etsitään isoin luku käyttäjän antamista luvuista

        if (luku1 > luku2 && luku1 > luku3)
        {
            Console.WriteLine("isoin luku on: " + luku1);
        }
        if (luku2 > luku1 && luku2 > luku3)
        {
            Console.WriteLine("isoin luku on: " + luku2);
        }
        else
        {
            Console.WriteLine("isoin luku on: " + luku3);
        }
    }
}