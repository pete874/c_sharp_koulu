// See https://aka.ms/new-console-template for more information
alku:
Console.WriteLine("Anna kokonaisluku 1-10 väliltä: ");
int luku = Int32.Parse(Console.ReadLine());
Console.WriteLine("Kertotaulu antamallesi numerolle: ");

for (int i = 1; i < 11; i++)
{
    int lasku = i * luku;
    Console.WriteLine(luku + " * " + i + " = " + lasku);
}
goto alku;