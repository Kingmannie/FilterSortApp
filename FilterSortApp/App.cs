using System;

namespace FilterSortApp
{
    //SOLID followed.
    //Single Responsibility, App represents result of Application execution.
    public class App
    {
        private static Filter filterObj = new Filter();
        private static Sort sortObj = new Sort();

        //constructor
        private App(Filter filter, Sort sort)
        {
            filterObj = filter;
            sortObj = sort;
        }

        //1. Print initial array, then halt and wait for keystroke
        //2. Remove/filter primes on keystroke
        //3. Sort in Descending on keystroke

        static void Main(string[] args)
        {

        //new string array as requested
        var num_Array = new String[100];

        for (var x = 0; x < num_Array.Length; x++)
        {
            num_Array[x] += x;
            Console.WriteLine(num_Array[x]);
        }
        
        Console.WriteLine("End of set array.");
        Console.ReadKey();
        
        var filterResult = filterObj.filter_action(num_Array);
        for (var x = 0; x < filterResult.Length; x++)
        {
            //print filtered array
            Console.WriteLine(filterResult[x]);
        }

        Console.WriteLine("End of filtered array.");
        Console.ReadKey();

        var sortResult = sortObj.sort_action(filterResult);
        for (var x = 0; x < sortResult.Length; x++)
        {
            //print sorted array
            Console.WriteLine(sortResult[x]);
        }

        Console.WriteLine("End of DESC sort.");
        Console.ReadKey();

        }
    }
}
