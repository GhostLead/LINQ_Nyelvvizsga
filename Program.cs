

//    Amir tudtam azt megcsináltam, viszont sajnos így is volt ami nem ment :(
//    A hétvégén megpróbálom jobban megérteni és alkalmazni a LINQ-t.

using LINQ_Nyelvvizsga;
using System.Text.Unicode;

List<Nyelvvizsga> nyelvvizsgak = new List<Nyelvvizsga>();

StreamReader sr = new StreamReader("sikeres.csv",encoding:System.Text.Encoding.UTF8);

sr.ReadLine(); // első sor "kihagyása"
while (!sr.EndOfStream)
{
    nyelvvizsgak.Add(new Nyelvvizsga(sr.ReadLine()));
}
sr.Close();

/*
sr = new StreamReader("sikertelen.csv", encoding: System.Text.Encoding.UTF8);

sr.ReadLine(); // első sor "kihagyása"
while (!sr.EndOfStream)
{
    sikertelen_nyelvvizsgak.Add(new Nyelvvizsga(sr.ReadLine()));
}
sr.Close();
*/

// 2.feladat

var top3 = nyelvvizsgak.OrderBy(x => x.Nepszeruseg).Take(3).ToList();
foreach (var item in top3)
{
    Console.WriteLine(item.Nyelv);
}

// 3. feladat

Console.Write("Adjon meg egy évet! : ");
int input = int.Parse(Console.ReadLine());

while (input > 2018 || input < 2009)
{
    Console.WriteLine("Hibás megadás!");
    Console.Write("Adjon meg egy évet! : ");
    input = int.Parse(Console.ReadLine());
}
string evInput = "ev" + input.ToString();

// 4. feladat


// 5. feladat
// mivel az előzőt nem tudtam, így ezt nemt tudom megcsinálni

// 6. feladat
// mivel az előző kettőt nem tudtam, így ezt nem tudom megcsinálni


