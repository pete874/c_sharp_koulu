// See https://aka.ms/new-console-template for more information
alku:
Console.WriteLine("Anna numero 0-999 väliltä, niin muutan sen sanoiksi: ");
int numero = Int32.Parse(Console.ReadLine());

if (numero > 999 || numero < 0)
{
    Console.WriteLine("Väärä numero");
    goto alku;
}

else if (numero < 10)
{
    string ykkonen;
    ykkonen = ykkoset(numero);
    Console.WriteLine(ykkonen);
}

else if (numero < 20)
{
    string pkymmenen;
    pkymmenen = kahdetkymmenet(numero);
    Console.WriteLine(pkymmenen);
}

static string ykkoset(int number)
{
    switch(number)
    {
        case 1:
            return "Yksi";
            break;
        case 2:
            return "Kaksi";
            break;
        case 3:
            return "Kolme";
            break;
        case 4:
            return "Neljä";
            break;
        case 5:
            return "Viisi";
            break;
        case 6:
            return "Kuusi";
            break;
        case 7:
            return "Seitsemän";
            break;
        case 8:
            return "Kahdeksan";
            break;
        case 9:
            return "Yhdeksän";
            break;
        default:
            return "virhe";
            break;
    }
}

static string kahdetkymmenet(int number)
{
    switch (number)
    {
        case 10:
            return "Kymmenen";
            break;
        case 11:
            return "Yksitoista";
            break;
        case 12:
            return "Kaksitoista";
            break;
        case 13:
            return "Kolmetoista";
            break;
        case 14:
            return "Neljätoista";
            break;
        case 15:
            return "Viisitoista";
            break;
        case 16:
            return "Kuusitoista";
            break;
        case 17:
            return "Seitsemäntoista";
            break;
        case 18:
            return "Kahdeksantoista";
            break;
        case 19:
            return "Yhdeksäntoista";
            break;
        default:
            return "väärin";
            break;
    }
}
