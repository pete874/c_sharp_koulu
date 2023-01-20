// See https://aka.ms/new-console-template for more information
alku:
Console.WriteLine("Anna kaksi lukua niin teen laskutoimituksia: ");
double luku1 = Double.Parse(Console.ReadLine());
double luku2 = Double.Parse(Console.ReadLine());
double plus = luku1 + luku2;
double miinus = luku1 - luku2;
double kerto = luku1 * luku2;
double jako = luku1 / luku2;
Console.WriteLine("Pluslasku " + plus);
Console.WriteLine("Miinuslasku " + miinus);
Console.WriteLine("Kertolasku " + kerto);
Console.WriteLine("Jakolasku " + jako);
goto alku;
