// See https://aka.ms/new-console-template for more information
alku:
Console.WriteLine("Anna kaksi lukua niin lasken jakojäännöksen: ");
int luku1 = int.Parse(Console.ReadLine());
int luku2 = int.Parse(Console.ReadLine());
int jakojaannos = luku1 % luku2;
Console.WriteLine("Tulos on: " + jakojaannos);
goto alku;
