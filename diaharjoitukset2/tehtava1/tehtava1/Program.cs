internal class Program
{
    private static void Main(string[] args)
    {
        alku:
        Console.WriteLine("Anna kaksi lukua niin plussaan ne toisiinsa: ");
        int luku1 = int.Parse(Console.ReadLine());
        int luku2 = int.Parse(Console.ReadLine());
        int summa = luku1 + luku2;
        Console.WriteLine("Tulos on: " + summa);
        goto alku;
    }
}