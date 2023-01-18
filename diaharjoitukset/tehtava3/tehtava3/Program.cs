internal class Program
{
    private static void Main(string[] args)
    {
        //pyydetään käyttäjältä luku ja tallennetaan se muuttujaan
        Console.WriteLine("Anna luku 0-9 välillä, niin muutetaan se sanaksi: ");
        int luku1 = int.Parse(Console.ReadLine());

        
        //tehdään switch case, joka tulostaa lauseen käyttäjän antamana luvun perusteella
        switch(luku1)
        {
            case 0:
                Console.WriteLine("En syönyt yhtään pannukakkua");
                break;

            case 1:
                Console.WriteLine("Söin yhden pannukakkua");
                break;

            case 2:
                Console.WriteLine("Söin kaksi pannukakkua");
                break;

            case 3:
                Console.WriteLine("Söin kolme pannukakkua");
                break;

            case 4:
                Console.WriteLine("Söin neljä pannukakkua");
                break;

            case 5:
                Console.WriteLine("Söin viisi pannukakkua");
                break;

            case 6:
                Console.WriteLine("Söin kuusi pannukakkua");
                break;

            case 7:
                Console.WriteLine("Söin seitsemän pannukakkua");
                break;

            case 8:
                Console.WriteLine("Söin kahdeksan pannukakkua");
                break;

            case 9:
                Console.WriteLine("Söin yhdeksän pannukakkua");
                break;

            default: 
                Console.WriteLine("Luku ei ollut 0-9 väliltä");
                break;
        }
    }
}