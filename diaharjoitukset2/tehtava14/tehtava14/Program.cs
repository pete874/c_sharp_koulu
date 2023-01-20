// See https://aka.ms/new-console-template for more information
alku:
Console.WriteLine("Anna kaksi lukua: ");
int luku1 = Int32.Parse(Console.ReadLine());
int luku2 = Int32.Parse(Console.ReadLine());

if (luku1 > 0 && luku2 > 0)
{
    Console.WriteLine("Molemmat luvut ovat positiivisia");
}
if (luku1 < 0 && luku2 < 0)
{
    Console.WriteLine("Molemmat luvut ovat negatiivisia");
}
if (luku1 < 0 && luku2 > 0 || luku1 > 0 && luku2 < 0)
{
    Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen");
}
goto alku;