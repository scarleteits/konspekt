

////1. tuvasta sisu võrdluse tühja stringiga, string andmetüüp
//Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?:");
//string nimi = Console.ReadLine();

//if (nimi == "")
//{
//    Console.WriteLine("Sa ei sisestanud oma nime, sadface 😔");
//}
//else if (nimi != "")
//{
//     Console.WriteLine("Tere "+nimi+"! häpifeiss 😀😀 おはよう");
//}
//else
//{
//    Console.WriteLine("Tundmatu sisestus.");
//}
////2 - vahemikud
//Console.WriteLine(nimi+", mis on sinu vanus?:");
//int kasutajavanus = int.Parse(Console.ReadLine());

////2.1 mitu tingimust pesastatud ifide abil
////if (kasutajavanus > 0)
////{
////    if (kasutajavanus < 18)
////    {
////        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
////    }
////    else
////    {
////        Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
////    }
////}

////2.2 mitu tingimust kasutades loogilist tehet "and"
//if (kasutajavanus > 0 && kasutajavanus < 18)
//{
//    Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
//}
//else
//{
//    Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
//}

////2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
//Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
//double kasutajaPikkus = double.Parse(Console.ReadLine());

//if (kasutajaPikkus < 1.00d)
//{
//    Console.WriteLine("Oled juntsu (Keemstar)");
//}
//else if (kasutajaPikkus < 1.25d && kasutajaPikkus >= 1.00d)
//{
//    Console.WriteLine("Oled peaaegu allameetrimees");
//}
//else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
//{
//    Console.WriteLine("OIOI, päkapikk enam ei olegi, "+nimi);
//}
//else if (kasutajaPikkus < 1.75d && kasutajaPikkus >= 1.5d)
//{
//    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte just natuke lühike");
//}
//else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75d)
//{
//    Console.WriteLine(nimi+", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö 😏'");
//}
//else
//{
//    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
//}

////3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid
//Console.WriteLine("tere, sisesta esimene liidetav arv");
//int arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("tere, sisesta teine liidetav arv");
//int arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("sisesta tehemärk: / * + - ^");
//string tehtetyyp = Console.ReadLine();

//int arv_1 = 0;
//int arv_2 = 0;
//Console.WriteLine("Sisesta arv 1");
//arv_1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Sisesta arv 2");
//arv_2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Vali millist tehet teha soovid +-/*");
//string tehtetüüp = Console.ReadLine();
//float tulemus = 0;
//if (tehtetüüp == "+")
//{
//    tulemus = arv_1 + arv_2;
//}
//if (tehtetüüp == "-")
//{
//    tulemus = arv_1 - arv_2;
//}
//if (tehtetüüp == "/")
//{
//    tulemus = arv_1 / arv_2;
//}
//if (tehtetüüp == "*")
//{
//    tulemus = arv_1 * arv_2;
//}

//Console.WriteLine(tulemus);

////4 parool, if ja string andmetüüp
//Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
//string password = Console.ReadLine();
//if (password == "simsalabim")
//{
//    Console.WriteLine("JES, parool on õige, oled sisse lubatud");
//}
//else if (password == "saatana" ||  password == "1234")
//{
//    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
//}
//else
//{
//    Console.WriteLine("Parool on vale");
//}

////5 värvituvastus
//Console.WriteLine("Mis on sinu lemmikvärv?:");
//string favColor = Console.ReadLine();
//if (favColor == "punane")
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//else if (favColor == "sinine")
//{
//    Console.BackgroundColor = ConsoleColor.Blue;
//}
//else if (favColor == "roheline")
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//}
//else if (favColor == "tumesinine")
//{
//    Console.BackgroundColor = ConsoleColor.DarkBlue;
//}
//else if (favColor == "must")
//{
//    Console.BackgroundColor = ConsoleColor.Black;
//}
//else if (favColor == "lilla")
//{
//    Console.BackgroundColor = ConsoleColor.DarkMagenta;
//}
//else if (favColor == "roosa")
//{
//    Console.WriteLine("Kahjuks ei ole roosa saadaval");
//}
//else if (favColor == "kollane")
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else if (favColor == "helesinine")
//{
//    Console.WriteLine("Kahjuks ei ole helesinine saadaval");
//}

////# Kolja kalkulaator - Kirjuta programm mis:
////#  - Küsib kasutajalt kas ta tahab ära mõõta papkasti või õlitünni.
//Console.WriteLine("Kas soovid mõõta pappkasti või õlitünni?");
//string valik = ();
//Console.WriteLine("banana");
//// Console -> adresseritav moodul või objekt (Roheline)
//// . -> midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
////    - komakohtadega andmetüüpidel komakoha tähistamine.
//// WriteLine -> adresseritav funktsioon objektist Console
//// () -> sulupaar mis omab endas funktsioonile vajalikku infot
////     - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisiõnu "ifi parameeter"
////     - kasutatakse ka matemaatilistes tehetes
//// [] -> tähistab massiive
//// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
////     - saab ka kasutada teksti sees muutujate kuvamiseks
//    // -> taane aitab arendajal aru saada millise koodiploki sees, miski on. Vajalik ka kompilaatorile.
//// "banana" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
//// ; -> iga koodilause lõppeb komakooloniga
//// // -> kommentaaritingmärk üherealise kommentaari jaoks (kaks / märki)

//int muutuja = 3;
//// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on
//// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
//// 3 -> väärtus mis sellele muutujale omistatakse

////võimalikud andmetüübid:
//int a = 1; // täisarv
//decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
//float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
//double d = 4.0d; // kümnendsüsteemis olev komakohaga arv, sarnane decimaliga
//char c1 = 'a'; // üksainus täht või tähemärk
//string s = "tekst"; // inimloetaval kujul tekst
//var x = "abc"; // ebamäärase tüübiga kohalik muutuja. 
//var y = 123;
//const int z = 3; // konstant-tüüpi muutujaid ei saa muuta, need on read-only

////põhilised matemaatilised tehted
//int liitmine = 1 + 1; // liitmine, kaks arvu kokku
//int lahutamine = 1 - 1; // lahutamine, esimene arv maha teisest
//int korrutamine = 1 * 1; //korrutamine, esimene arv korrutatakse teisega
//int jagamine = 1 / 1; //jagamine, esimene arv jagatakse teisega
//double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
//double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse

//int arv = 0; // sobib
//string sõne = "abc"; //sobib
////string string = "abc"; //ei sobi

//// muutuja nimeks ei sobi järgnevad sõnad:
////abstract, as, base, bool, break, byte, case,
////catch, char, checked, class, const, continue, decimal,
////default, delegate, do, double, else, enum, event,
////explicit, extern, false, finally, fixed, float, for
////foreach, goto, if, implicit, in, int,
////interface, internal, is, lock, long, namespace, new,
////null, object, operator, out, override, params,
////private, protected, public, readonly, ref, return, sbyte,
////sealed, short, sizeof, stackalloc, static, string, struct,
////switch, this, throw, true, try, typeof, uint,
////ulong, unchecked, unsafe, ushort, using, virtual, void,
////volatile, while

////Ülesanne, kasutades süntaksiseletust, kirjelda kommentaariga iga koodirida
//Console.WriteLine("tere, sisesta esimene liidetav arv");
////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
//// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
//int arv1 = int.Parse(Console.ReadLine());
//// instantseerime muutuja "arv_1", ning ütleme et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
//// mille saame kasutajalt Console.ReadLine() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
//// asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. Lause lõppeb lauselõpumärgiga ; .
//Console.WriteLine("tere, sisesta teine liidetav arv");
////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
//// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
//int arv2 = int.Parse(Console.ReadLine());
//// instantseerime muutuja "arv_1", ning ütleme et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
//// mille saame kasutajalt Console.ReadLine() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
//// asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. Lause lõppeb lauselõpumärgiga ; .
//Console.WriteLine("sisesta tehemärk: / * + - ^");
////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
//// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
//string tehtetyyp = Console.ReadLine();
//// tekitame muutuja "tehtetyyp", mille ette paneme andmetüübiks string ehk ütleme et seal on tekst, ning võrdusmärgi abil omistame talle
//// konsooli rea pealt loetu info, mis saame kasutades "Console" mooduli, ReadLine() funktsiooni. lause lõppeb lauselõpumärgiga ; ..

//int tulemus = 0;
//if (tehtetyyp == "+")
//// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "+"
//{
//    tulemus = arv1 + arv2;
//}
//// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites
//// muutujast arv_1 muutuja arv_2. Lause lõppeb lauselõpumärgiga sulgude sees
//if (tehtetyyp == "-")
//// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "-"
//{
//    tulemus = arv1 - arv2;
//}
//// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus lahutades
//// muutujast arv_1 muutuja arv_2. Lause lõppeb lauselõpumärgiga sulgude sees
//if (tehtetyyp == "*")
//// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "*"
//{
//    tulemus = arv1 * arv2;
//}
//// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus korrutades
//// muutujast arv_1 muutuja arv_2. Lause lõppeb lauselõpumärgiga sulgude sees
//if (tehtetyyp == "/")
//// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "/"
//{
//    tulemus = arv1 / arv2;
//}
//// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus jagades
//// muutujast arv_1 muutuja arv_2. Lause lõppeb lauselõpumärgiga sulgude sees
//if (tehtetyyp == "^")
//// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "^"
//{
//    tulemus = (int)Math.Pow(arv1, arv2);
//}

//Console.WriteLine(tulemus);

Console.WriteLine("Sisesta ostusumma");
//Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
double ostusumma = double.Parse(Console.ReadLine();
if (ostusumma > 100)
{
    Console.WriteLine("Saad 20% allahindlust!");
}
//Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
else if (ostusumma > 101 && ostusumma > 50)
{
    Console.WriteLine("Saad10%allahindlust");
}
//Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
//// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
else if (ostusumma < 51 && ostusumma > 20)
{
    Console.WriteLine("Saad 5% allahindlust");
}
else if (ostusumma < 21)
{
    Console.WriteLine("Allahindlust ei saa :(");
}
else if (ostusumma < 1)
{
    Console.WriteLine("Sisestatud vigane arv");
}
// 1. do-while
int d = 0;
do // "do" on kaitstud sõna, mis alustab do-while tsüklit pärast mida on koodiplokk, ning ütleb et tee seda koodi
{
    d++;
} while (d != 5)
// 2. while
while (true); // niikaua kuni while järel olevate sulgude vahel olev tingimus on täidetud.
int i = 1; //tsüklimuutuja mis kontrollib "while" tsükli tööd
while (i < 5) //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab tihtipeale välimist tsüklimuutujat
              //antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, sulgude vahel, kontrollibki tingimuse abil, selle
              //muutuja olekut. Siin kontrollitakse, et tsükkel ei oleks suurem kui 5, kui ta on, siis tsükli töö lõppeb.
{
    //koodiplokk kus midagi tehakse
    i++; //ning seejärel muudetakse tsüklimuutuja "i" olekut, antud juhul liidetakse 1 juurde
}

/* Sõne tööriistad jm tekstiga seotud */
string alfa = "a\nb";  // \n -> tek´itab ühe sõne sisse reamurde , sõne kus on ühe "\n" omab kahte rida
string beta = $"a {alfa} b"; // $ -> lubab kasutada muutujaid loogeliste sulgude vahel 