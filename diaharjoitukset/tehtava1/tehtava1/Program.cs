internal class Program
{
    private static void Main(string[] args)
    {
        
        
        //pyydetään käyttäjältä kaksi lukua ja tallennetaan ne muuttujiin
        
        Console.WriteLine("Anna luku: ");
        int luku1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Anna luku: ");
        int luku2 = int.Parse(Console.ReadLine());

        //Tehdään if-lause, jolla tulostetaan suuruus järjestykseen käyttäjän antamat luvut

        if (luku1 < luku2)
        {
            Console.WriteLine(luku1 + ", " + luku2);
        }
        else
        {
            Console.WriteLine(luku2 + ", " + luku1);
        }
    }
}