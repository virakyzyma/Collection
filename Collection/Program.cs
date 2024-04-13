using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> array = new MyCollection<int>();
            MyCollection<string> strings = new MyCollection<string>();

            array.Add(new int[] { 1, 1, 1, 1});
            Console.WriteLine(GetSumOfNumbers(array));

            strings.Add(new string[] { "Hello", "World", "Today", "Is", "April", "11" });
            Console.WriteLine(string.Join(" ", GetFirstSymbolsOfEveryRow(strings)));

            Console.WriteLine(GetCountOfSymbolsOfWholeCollection(strings));
        }

        static int GetSumOfNumbers(MyCollection<int> collection)
        {
            return collection.Sum();
        }

        static int GetCountOfSymbolsOfWholeCollection(MyCollection<string> collection)
        {
            return collection.Sum(s => s.Length);
        }

        static char[] GetFirstSymbolsOfEveryRow(MyCollection<string> collection)
        {
            return collection.Select(s => s.FirstOrDefault()).ToArray();
        }

        public class MyCollection<T> : Collection<T>
        {
            public void Add(IEnumerable<T> items)
            {
                foreach (var item in items)
                {
                    Add(item);
                }
            }
        }
    }
}