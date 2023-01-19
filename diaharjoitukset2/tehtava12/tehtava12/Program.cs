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
    for (int i = 0; i < 13; i++)
    {
        Console.Write(luku + " ");
    }
    Console.Write("\n");
    for (int i = 0; i < 13; i++)
    {
        Console.Write(luku);
    }
    Console.Write("\n");
    for (int i = 0; i < 11; i++)
    {
        Console.Write(luku + " ");
    }
    Console.Write("\n");
    for (int i = 0; i < 13; i++)
    {
        Console.Write(luku);
    }
    Console.Write("\n");
    goto alku;
}
else
{
    Console.WriteLine("syötä luku joka on isompi kuin 10");
    goto alku;
}