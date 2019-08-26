using System;
using System.IO;
using System.Linq;

namespace CsvParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var csv = @"Year,Title,Production Studio,
                        2008,Iron Man,Marvel Studios,";
            var sr = new StringReader(csv);
            var csvReader = new CsvReader(sr);
            foreach (var line in csvReader.Lines)
                Console.WriteLine(line.First(p => p.Key == "Title").Value);
        }
    }
}