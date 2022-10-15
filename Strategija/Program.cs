using System;

namespace RPPOON_LV7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 5, 2, 6, 1, 6961, 59 };
            Console.WriteLine(String.Join(",", numbers));
            SortStrategy strategy = new BubbleSort();
            strategy.Sort(numbers);
            Console.WriteLine(String.Join(",", numbers));
            SearchStrategy searchStrategy = new LinearSearch();
            searchStrategy.Search(numbers, 2);


        }
    }
}
