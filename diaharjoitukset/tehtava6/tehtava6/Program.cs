internal class Program
{
    private static void Main(string[] args)
    {
        //pyydetään käyttäjä numero 1-9 väliltä
        Console.WriteLine("Paljonko sait pisteitä? (1-9)");
        int pisteet = int.Parse(Console.ReadLine());

        // switch case riippuen syötetystä pistemäärästä
        switch(pisteet)
        {
            case 1:
            case 2:
            case 3:
                pisteet *= 10;
                Console.WriteLine("Bonus pisteesi ovat nyt: " + pisteet);
                break;
            case 4:
            case 5:
            case 6:
                pisteet *= 100;
                Console.WriteLine("Bonus pisteesi ovat nyt: " + pisteet);
                break;
            case 7:
            case 8:
            case 9:
                pisteet *= 1000;
                Console.WriteLine("Bonus pisteesi ovat nyt: " + pisteet);
                break;
            default:
                Console.WriteLine("virheellinen määrä");
                break;

        }
    }
}