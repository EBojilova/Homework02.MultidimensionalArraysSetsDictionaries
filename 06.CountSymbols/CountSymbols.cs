using System;
using System.Linq;

class CountSymbols
{
    static void Main(string[] args)
    {
        char[] symbols = Console.ReadLine().ToCharArray();
        Array.Sort(symbols);
        var groups = symbols.GroupBy(x => x);
        foreach (var group in groups)
        {
            Console.WriteLine("{0}: {1} time/s", group.Key, group.Count());
        }
    }
}
