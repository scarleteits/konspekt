// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");

//1. tuvasta sisu võrdluse tühja stringiga, string andmetüüp
Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?:");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("Sa ei sisestanud oma nime, sadface 😔");
}
else if (nimi != "")
{
    Console.WriteLine("Tere" + nimi + "! happyface 😊");
}
else
{
    Console.WriteLine("Tundmatu sisestus. ");
}
//2 - vahemikud
Console.WriteLine(nimi + ", mis on sinu vanus?:");
int kasutajavanus = int.Parse(Console.ReadLine());

//2.1 mitu tingimust pesastatud ifide abil
if (kasutajavanus > 0)
{
    if (kasutajavanus < 18)
    {
        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterit ilma 😔");
    }
    else
    {
        Console.WriteLine("Yippie! saad monsut osta 😍");
    }
        
}

//2.2 mitu tingimust kasutades loogilist tehet "and"
if (kasutajavanus > 0  && kasutajavanus < 18)
{
    Console.WriteLine("Enerksi ei saa, oled alakas, Monsterit ilma 😔");
}
else
{
    Console.WriteLine("Yippie! saad monsut osta 😍");
}

//2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
double kasutajaPikkus = double.Parse(Console.ReadLine());

if (kasutajaPikkus < 1.00d)
{
    Console.WriteLine("Oled juntsu (Keemstar)");
}
else if (kasutajaPikkus < 1.25d && kasutajaPikkus >= 1.00d)
{
    Console.WriteLine("Oled peaaegu allameetrimees");
}
else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
{
    Console.WriteLine("Aasiapärane pikkus eesti mehe kohta, läheb paremaks aga ikka lyhike ");
}
else if (kasutajaPikkus < 1.75d && kasutajaPikkus >= 1.50d)
{
    Console.WriteLine("Oled juba päris hea pikkusega, alla eesti mehe keskmise aga palju parem");
}
else if (kasutajaPikkus < 2.00 && kasutajaPikkus >= 1.75d)
{
    Console.WriteLine("norm vend oled, päris pikk");
}


int arv_1 = 0;
int arv_2 = 0;
Console.WriteLine("Sisesta arv 1");
arv_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Sisesta arv 2");
arv_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Vali millist tehet teha soovid +-/*");
string tehtetüüp = Console.ReadLine();
float tulemus = 0;
if (tehtetüüp == "+")
{
    tulemus = arv_1 + arv_2;
}
if (tehtetüüp == "-")
{
    tulemus = arv_1 - arv_2;
}
if (tehtetüüp == "/")
{
    tulemus = arv_1 / arv_2;
}
if (tehtetüüp == "*")
{
    tulemus = arv_1 * arv_2;
}

Console.WriteLine(tulemus);

//4 parool, if ja string andmetüüp
Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
string password = Console.ReadLine();
if (password == "simsalabim")
{
    Console.WriteLine("JES, parool on õige, oled sisse lubatud");
}
else if (password == "saatana" ||  password == "1234")
{
    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
}
else
{
    Console.WriteLine("Parool on vale");
}

//5 värvituvastus
Console.WriteLine("Mis on sinu lemmikvärv?:");
string favColor = Console.ReadLine();
if (favColor == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favColor == "sinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favColor == "roheline")
{
    Console.BackgroundColor = ConsoleColor.Green;
}
else if (favColor == "tumesinine")
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
}
else if (favColor == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
}
else if (favColor == "lilla")
{
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
}
else if (favColor == "roosa")
{
    Console.WriteLine("Kahjuks ei ole roosa saadaval");
}
else if (favColor == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favColor == "helesinine")
{
    Console.WriteLine("Kahjuks ei ole helesinine saadaval");
}


