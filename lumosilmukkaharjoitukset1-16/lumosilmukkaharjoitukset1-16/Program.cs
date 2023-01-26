internal class Program
{
    private static void Main(string[] args)
    {
        // Valikko tehtäville switch casen avulla
        alku:

        Console.Clear();
        Console.WriteLine("Valitse valikosta tehtävä");
        Console.WriteLine("1. Tehtävä");
        Console.WriteLine("2. Tehtävä");
        Console.WriteLine("3. Tehtävä");

        string valinta;
        int numero;
        valinta = Console.ReadLine();

        numero = Int32.Parse(valinta);

        switch (numero)
        {
            case 1:
                tehtava1();
                goto alku;
                break;
            case 2:
                tehtava2();
                goto alku;
                break;
            case 3:
                tehtava3();
                goto alku;
                break;
        }
        




    }

    // Tehtävien metodit alkavat tästä
    static void tehtava1()
    {
        Console.Clear();
        Console.WriteLine("S01. Tee ohjelma, laskee, paljonko joudut maksamaan takaisin, kun lainasit 5000€ kahdeksi vuodeksi 2% korolla");
        double laina = 5000;

        for (int i = 0; i < 2; i++)
        {
            laina *= 1.02;
        }

        Console.WriteLine("Tulos on " + laina);
        Console.WriteLine("Paina enter jatkaaksesi");
        Console.ReadLine();
    }
        

        static void tehtava2()
    {
        Console.Clear();
        Console.WriteLine("S02. Tee ohjelma, joka laskee annetun luvun kertoman");
        Console.WriteLine("Anna numero niin lasken sen kertoman");
        int luku = Int32.Parse(Console.ReadLine());
        int kertoma = 1;
        for (int i = 1; i <= luku; i++)
        {
            kertoma *= i;
        }
        Console.WriteLine("Luvun " + luku + " kertoma on " + kertoma);
        Console.WriteLine("Paina enter jatkaaksesi");
        Console.ReadLine();
    }

    static void tehtava3()
    {
        Console.Clear();
        Console.WriteLine("S03. Tee ohjelma, joka etsii luvun 3 ensimmäisen esiintymän taulukosta [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3]");
        int[] taulukko = { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };

        for (int i = 0;i < taulukko.Length;i++)
        {
            if (3 == taulukko[i])
            {
                Console.WriteLine("Ensimmäinen luku 3 on indeksissä " + i);
                break;
            }
        }
        Console.WriteLine("Paina enter jatkaaksesi");
        Console.ReadLine();

    }
}