using System;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string doctorQuote = "There is no point in growing up if you can't be childish sometimes.";
            string[] words = doctorQuote.Split(' ');
            Array.Sort(words);
            string sortedQuote = string.Join(" ", words);
            Console.WriteLine(sortedQuote);
        }
    }
}
