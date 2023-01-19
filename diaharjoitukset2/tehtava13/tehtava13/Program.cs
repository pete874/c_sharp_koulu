// See https://aka.ms/new-console-template for more information
alku:
Console.WriteLine("Anna nimesi: ");
string nimi = Console.ReadLine();

char[] nimiArray = nimi.ToCharArray();
Array.Reverse(nimiArray);
string nimiString = string.Join("", nimiArray);
Console.WriteLine(nimiString);
goto alku;
