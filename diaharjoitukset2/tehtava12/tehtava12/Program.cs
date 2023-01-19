// See https://aka.ms/new-console-template for more information
alku:
Console.WriteLine("Anna kokonaisluku, joka on isompi kuin 10: ");
string luku = Console.ReadLine();
int luku2;

try
{
    luku2 = Int32.Parse(luku);
}
catch
{
    Console.WriteLine("syötä kokonaisluku");
    goto alku;
}
if (luku2 > 10)
{
    for (int i = 0; i < 11; i++)
    {
        for (int j = 0; j < 13; j++)
        {
            Console.Write(luku2 + " ");
        }
        Console.Write("\n");
        for (int k = 0; k < 13; k++)
        {
            Console.Write(luku2);
        }
        Console.Write("\n");
    }
    goto alku;
}
else
{
    Console.WriteLine("syötä luku joka on isompi kuin 10");
    goto alku;
}