internal class Program
{
    private static void Main(string[] args)
    {
        //tallennetaan viisi lukua muuttujiin
        int luku1 = 7;
        int luku2 = 8;
        int luku3 = 9;
        int luku4 = 10;
        int luku5 = 11;

        //tehdään if-lause, jolla etsitään isoin luku viidestä muuttujasta
        
        if (luku1 > luku2 && luku1 > luku3 && luku1 > luku4 && luku1 > luku5)
        {
            Console.WriteLine("luku " + luku1 + " on suurin");
        }

        if (luku2 > luku1 && luku2 > luku3 && luku2 > luku4 && luku2 > luku5)
        {
            Console.WriteLine("luku " + luku2 + " on suurin");
        }

        if (luku3 > luku2 && luku3 > luku1 && luku3 > luku4 && luku3 > luku5)
        {
            Console.WriteLine("luku " + luku3 + " on suurin");
        }

        if (luku4 > luku2 && luku4 > luku3 && luku4 > luku1 && luku4 > luku5)
        {
            Console.WriteLine("luku " + luku4 + " on suurin");
        }

        if (luku5 > luku1 && luku5 > luku2 && luku5 > luku3 && luku5 > luku4)
        {
            Console.WriteLine("luku " + luku5 + " on suurin");
        }
    }
}