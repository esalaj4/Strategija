using System;
using System.Collections.Generic;

namespace Adapter.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset("zad.txt");
            IList<List<double>> data;
            data = dataset.GetData();
            

            Analyzer3rdParty analyzer3RdParty = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer3RdParty);

            double[] rows = adapter.CalculateAveragePerRow(dataset);
            double[] columns = adapter.CalculateAveragePerColumn(dataset);

            Console.WriteLine("Average per rows");
            foreach(var row in rows)
            {
                Console.WriteLine(row);
            }

            Console.WriteLine("Average per columns");
            foreach (var column in columns)
            {
                Console.WriteLine(column);
            }
        }
    }
}
