// See https://aka.ms/new-console-template for more information
alku:
Console.WriteLine("Anna lause niin etsin lauseen pisimmän sanan: ");
string lause;
lause = Console.ReadLine();
string[] sanat = lause.Split(' ');
string pisinSana = sanat[0];

for (int i = 0; i < sanat.Length; i++)
{
    if (sanat[i].Length > pisinSana.Length)
    {
        pisinSana = sanat[i];
    }
}

Console.WriteLine(pisinSana);
goto alku;
