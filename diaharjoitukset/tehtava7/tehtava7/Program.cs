internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna numero 0-999 väliltä, niin muutetaan se sanoiksi");
        int luku = int.Parse(Console.ReadLine());
        string kymmenet = "";


        switch(luku)
        {
            case 1:
                kymmenet += "yksi";
                Console.WriteLine(kymmenet);
                break;
            case 2:
                kymmenet += "kaksi";
                Console.WriteLine(kymmenet);
                break;
            case 3:
                kymmenet += "kolme";
                Console.WriteLine(kymmenet);
                break;
            case 4:
                kymmenet += "neljä";
                Console.WriteLine(kymmenet);
                break;
            case 5:
                kymmenet += "viisi";
                Console.WriteLine(kymmenet);
                break;
            case 6:
                kymmenet += "kuusi";
                Console.WriteLine(kymmenet);
                break;
            case 7:
                kymmenet += "seitsemän";
                Console.WriteLine(kymmenet);
                break;
            case 8:
                kymmenet += "kahdeksan";
                Console.WriteLine(kymmenet);
                break;
            case 9:
                kymmenet += "yhdeksän";
                Console.WriteLine(kymmenet);
                break;
        }
    }
}