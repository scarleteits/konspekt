// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Threading.Channels;

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

//# Kolja kalkulaator - Kirjuta programm mis:
//#  - Küsib kasutajalt kas ta tahab ära mõõta papkasti või õlitünni.
Console.WriteLine("Kas tahad mõõta ära kasti või tünni?");
string valik = Console.ReadLine();
//#    - olenevalt kasutaja sisestusest küsib ta:
if (valik == "tünn")
{
    //#   - - tünni jaoks:
    //#   - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
    Console.WriteLine("Kas sa tead tünni raadiust (r) või põhja läbimõõtu (d)");
    string rvõid = Console.ReadLine();
    Console.WriteLine("Sisesta see mõõt:");
    double mõõt = double.Parse(Console.ReadLine());
    if (rvõid == "d")
    {
        mõõt = mõõt / 2;
    }
    else if (rvõid != "r")
    {
        Console.WriteLine("Sisend ei ole tuntav");
    }

    //#   - - - tünni kõrgust
    Console.WriteLine("Kui kõrge on su tünn");
    int kõrgus = int.Parse(Console.ReadLine());

    //#    - - - kaane paksus (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
    Console.WriteLine("kui paks on tünni kaas?");
    int kaanepaksus = int.Parse(Console.ReadLine());

    //#     - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
    double tünnipõhiS = Math.PI * (mõõt * mõõt);
    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
    double küljepindala = tünnipõhiS * kõrgus;
    double kogupindala = (tünnipõhiS * 2) + küljepindala;
    Console.WriteLine($"Sinu tünn mahutab {mahtV} \nTünni küljepindala on {küljepindala} \nKogupindala aga on{kogupindala}");
}
//#   - - kasti jaoks:
else if (valik == "kast")
{
    //#     - - - Kas kast on kuubiku kujuline või risttahuka kujuline
    Console.WriteLine("Kas su kast on kuubik (k) või risttahukas (r)? ");
    string kastitüüp = Console.ReadLine();
    if (kastitüüp == "k")
    {
        //#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
        Console.WriteLine("Sisesta kasti küljepikkus:");
        double külgA = double.Parse(Console.ReadLine());
        double kuubik = Math.Pow(külgA, 3);
        double küljepindala = (külgA * külgA) * 6;
        double diagonaal = külgA * Math.Sqrt(3);
        Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on {diagonaal}");
    }
    //#   - - - - kui on risttahukas siis küsib kasutajalt:
    else if (kastitüüp == "r")
    {
        //#    - - - - - pikima külje pikkust,
        Console.WriteLine("Mis on sinu kasti kõige pikim külg?:");
        double pikkkülg = double.Parse(Console.ReadLine());
        //#    - - - - - lühima külje pikkust ja 
        Console.WriteLine("Mis on sinu kasti kõige lühim külg?:");
        double lühikekülg = double.Parse(Console.ReadLine());
        //#    - - - - - kasti kõrgus
        Console.WriteLine("Mis on sinu kasti kõrgus?:");
        double kõrgus = double.Parse(Console.ReadLine());

        //#  - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
        double V = pikkkülg * lühikekülg * kõrgus;
        double kogupindala = 2 * ((pikkkülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkkülg * kõrgus));
        double diagonaal = Math.Sqrt((pikkkülg * pikkkülg) + (lühikekülg * lühikekülg) + (kõrgus * kõrgus));
        Console.WriteLine($"Sinu kast mahutab {V} \nKasti küljepindala on {kogupindala} \nDiagonaal aga on {diagonaal}")
    }
    
}

Console.WriteLine("banana");
// Console -> adresseritav moodul või objekt (Roheline)
// . -> midagi selle objekti seest, sarnane windowsi kausta pathis olev slashiga
// WriteLine -> adresseritav funktsioon objektist Console
// () -> sulupaar mis omab endas funktsioonile vajalikku infot
//      - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisisõnu "ifi parameeter"
// [] -> tähistab massiive
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
//     - saab ka kasutada teksti sees muutujate kuvamiseks
// -> taane aitab arendajal aru saada millise koodiploki sees, miski on. Vajalik ka kompilaatorile.
// "banana" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
// ; -> iga koodlause lõppeb komakooloniga

int muutuja = 3;
// int ->  muutuja nime ess olev andmetüübi kirjeldus. See näitab ära mistüüpi andmed selle muutuja sees on
// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
// 3 -> väärtus mis sellele muutujale omistatakse

//võimalikud andmetüübid:
int a = 1; // täisarv
decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
float c = 3.0f // kümnendsüsteemis olev ujukomaga arv
double d = 4.0d // kümnendsüsteemis olev komakohaga arv, sarnane decimaliga
char c1 = 'a'; // üksainus täht või tähemärk
string s = "tekst"; // inimloetaval kujul tekst
var x = "abc"; // ebamäärase tüübiga kohaliku muutuja.
const int z = 3; // konstant-tüüpi muutujaid ei saa muuta, need on read-only