﻿#region 1.Feladat|szamok
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("1. Feladat|szamok");
Console.ResetColor();

// Files
Console.Write("Adj meg egy számot! (1-3): ");
Console.ForegroundColor = ConsoleColor.Yellow;
string szam = Console.ReadLine();
Console.ResetColor();
string file_name = $"szamok{szam}.txt";

//if (!File.Exists(file_name))
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("A megadott fájl nem létezik.");
//    Console.ResetColor();
//    return;
//}

string[] sorok = File.ReadAllLines(file_name);

Console.Write("A választott fájl: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(file_name);
Console.ResetColor();

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// a. Feltöltés tömbbe
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("a. Feladat|Feltöltés tömbbe");
Console.ResetColor();

int meret = Convert.ToInt32(sorok[0]);
int[] szamok = new int[meret];

for (int i = 1; i < sorok.Length; i++)
{
    szamok[i - 1] = Convert.ToInt32(sorok[i]);
}

Console.WriteLine("Csak beolvassa a fájlt egy listába, nincs mit kiírni...");

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// b. Kiírás elemenként
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("b. Feladat|Kiírás elemenként");
Console.ResetColor();

for (int i = 0; i < szamok.Length; i++)
{
    Console.WriteLine($"{i + 1}. szám: {szamok[i]}");
}

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// c. Kiírás tabbal elválasztva
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("c. Feladat|Kiírás tabbal elválasztva");
Console.ResetColor();

Console.WriteLine(string.Join("\t", szamok));

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// d. Párosával kiírás fájlba
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("d. Feladat|Párosával kiírás fájlba");
Console.ResetColor();

using (StreamWriter sw = new StreamWriter("parosaval.txt"))
{
    for (int i = 0; i < szamok.Length - 1; i += 2)
    {
        double atlagf = (szamok[i] + szamok[i + 1]) / 2.0;
        sw.WriteLine($"{szamok[i]};{szamok[i + 1]};{atlagf:F2}");
    }
}
Console.WriteLine("Párosával írás fájlba kész: parosaval.txt");

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// e. Számok összege
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("e. Feladat|Számok összege");
Console.ResetColor();

int osszeg = szamok.Sum();
Console.WriteLine("A számok összege: " + osszeg);

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// f. Számok átlaga
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("f. Feladat|Számok átlaga");
Console.ResetColor();

double atlag = szamok.Average();
Console.WriteLine("A számok átlaga: " + atlag);

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// g. Legnagyobb érték
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("g. Feladat|Legnagyobb érték");
Console.ResetColor();

int max = szamok.Max();
Console.WriteLine("A legnagyobb érték: " + max);

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// h. Legkisebb érték
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("h. Feladat|Legkisebb érték");
Console.ResetColor();

int min = szamok.Min();
Console.WriteLine("A legkisebb érték: " + min);

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// i. Nulla ellenőrzés
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("i. Feladat|Nulla ellenőrzés");
Console.ResetColor();

bool vanNulla = szamok.Contains(0);
if (vanNulla)
{
    Console.WriteLine("Van 0 a számok között.");
}
else
{
    Console.WriteLine("Nincs 0 a számok között.");
}

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// j. Első negatív szám pozíciója
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("j. Feladat|Első negatív szám pozíciója");
Console.ResetColor();

int elsoNegativIndex = Array.FindIndex(szamok, x => x < 0);
if (elsoNegativIndex >= 0)
{
    Console.WriteLine($"Első negatív szám pozíciója: {elsoNegativIndex + 1}");
}
else
{
    Console.WriteLine("Nincs negatív szám.");
}

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// k. Pozitív számok aránya
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("k. Feladat|Pozitív számok aránya");
Console.ResetColor();

double pozitivSzazalek = (double)szamok.Count(x => x > 0) / szamok.Length * 100;
Console.WriteLine($"Pozitív számok aránya: {pozitivSzazalek:F2}%");

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---
#endregion

#region pause
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Nyomj entert a továbblépéshez!");
while (Console.ReadKey().Key != ConsoleKey.Enter)
{
}
Console.WriteLine("1 másodperc...");
Thread.Sleep(1000);
Console.ResetColor();
#endregion

#region 2.Feladat|nevek
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2. Feladat");
Console.ResetColor();

string nevek = "nevek.txt";

//if (!File.Exists(nevek))
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("A 'nevek.txt' fájl nem található.");
//    Console.ResetColor();
//    return;
//}

string[] sorokN = File.ReadAllLines(nevek);

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// a. Két keresztnevűek száma
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("a. Feladat|Két keresztnevűek száma");
Console.ResetColor();

int ketKeresztnev = sorokN.Count(n => n.Split(' ').Length == 3);
Console.WriteLine($"Két keresztnévvel rendelkezők száma: {ketKeresztnev}");

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// b. Névsor rendezése és kiírása
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("b. Feladat|Névsor rendezése és kiírása");
Console.ResetColor();

Array.Sort(sorokN);
Console.WriteLine("Névsor:");
foreach (var nev in sorokN)
{
    Console.WriteLine(nev);
}

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// c. Három véletlenszerű név fájlba írása
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("c. Feladat|Három véletlenszerű név fájlba írása");
Console.ResetColor();

Random rnd = new Random();
var randomNevek = sorokN.OrderBy(x => rnd.Next()).Distinct().Take(3);
File.WriteAllLines("felelok.txt", randomNevek);
Console.WriteLine("Három véletlenszerű név írása kész: felelok.txt");

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// d. Nevek nagybetűs formában fájlba írása
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("d. Feladat|Nevek nagybetűs formában fájlba írása");
Console.ResetColor();

File.WriteAllLines("nagybetus.txt", sorokN.Select(n => n.ToUpper()));
Console.WriteLine("Nagybetűs nevek írása kész: nagybetus.txt");

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// e. Keresztneved keresése (Csongor)
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("c. Feladat|Keresztneved keresése");
Console.ResetColor();

bool talalatVan = false;
for (int i = 0; i < sorokN.Length; i++)
{
    string[] nevReszek = sorokN[i].Split(' ');
    if (nevReszek.Contains("Csongor"))
    {
        Console.WriteLine($"A keresztneved megtalálható a(z) {i + 1}. sorban: {sorokN[i]}");
        talalatVan = true;
        break;
    }
}
if (!talalatVan)
{
    Console.WriteLine("A keresztneved nem található meg a fájlban."); // ezt így nem tudom le elenőrizni
}

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---

// f. Első és utolsó Szabó keresése
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("d. Feladat|Első és utolsó Szabó keresése");
Console.ResetColor();

int elsoSzabo = -1;
int utolsoSzabo = -1;

for (int i = 0; i < sorokN.Length; i++)
{
    string[] nevReszek = sorokN[i].Split(' ');
    if (nevReszek[0] == "Szabo")
    {
        if (elsoSzabo == -1)
        {
            elsoSzabo = i;
        }
        utolsoSzabo = i;
    }
}

if (elsoSzabo != -1)
{
    Console.WriteLine($"Az első Szabó nevű személy a(z) {elsoSzabo + 1}. sorban található: {sorokN[elsoSzabo]}");
    Console.WriteLine($"Az utolsó Szabó nevű személy a(z) {utolsoSzabo + 1}. sorban található: {sorokN[utolsoSzabo]}");
}
else
{
    Console.WriteLine("Nem található Szabó nevű személy a fájlban.");
}

// ---sortores---
Thread.Sleep(500);
Console.WriteLine("");
// ---sortores---
#endregion
