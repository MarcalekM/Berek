using Berek;
using System.Linq;

List<Dolgozo> dolgozok = new();

using StreamReader sr = new(
    path: @"../../../src/berek2020.txt",
    encoding: System.Text.Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) dolgozok.Add(new(sr.ReadLine()));

Console.WriteLine($"3. feladat:\n\tA dolgozók száma: {dolgozok.Count()}");

var f4 = dolgozok.Average(d => d.Ber);
Console.WriteLine($"4. feladat:\n\tA dolgozók átlagbére 2020-ben: {f4/1000:0.0} ezer forint");

Console.Write("\n5. feladt:\nAdjon meg egy részleget:  ");
var f5 = Console.ReadLine();

if(dolgozok.Where(d => d.Reszleg.Equals(f5)).Count() != 0)
{
    var f6 = dolgozok.Where(d => d.Reszleg.Equals(f5)).OrderByDescending(d => d.Ber).First();
    Console.WriteLine($"\n6. feladat:\n{f6.ToString()}");
}
else Console.WriteLine($"\n6. feladat:\n\t{"Nincs ilyen részleg"}");

var f7 = dolgozok
    .GroupBy(d => d.Reszleg)
    .ToDictionary(d => d.Key, d => d.Count())
    .OrderBy(d => d.Key);
Console.WriteLine("\n7. feladat:");
foreach (var f in f7) Console.WriteLine($"\t{f.Key,11}: {f.Value}");