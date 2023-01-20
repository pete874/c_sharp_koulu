internal class Program
{
    private static void Main(string[] args)
    {
    alku:
        int numero;
        Console.WriteLine("Kirjoita numero 0-999 väliltä, niin muutan sen sanaksi: ");

        if (numero > 999 | numero <0)
        {
            Console.WriteLine("Väärä numero. Anna numero 0-999 väliltä")
            goto alku;
        }

        else if (numero < 10)
        {
            string ykkoset = ykkoset(numero);
            Console.WriteLine(ykkoset);
        }
        
    }
}