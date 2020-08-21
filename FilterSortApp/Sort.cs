using System;

namespace FilterSortApp
{
    //Single Responsibility, Sort represents DESC sort of string array param.
    public class Sort
    {
        public string[] sort_action(string[] sortArray)
        {
            //var newArray = Array.Empty<string>();
            Int16 counter = 0;

            for (int x = 0; x < sortArray.Length; x++)
            {
                if (sortArray[x] != null)
                {
                    counter += 1;
                }
            }

            var newArray = new String[counter];

            foreach (string x in sortArray)
            {
                if (x != null)
                {
                    counter--;
                    newArray[counter] = sortArray[Int32.Parse(x)];
                }
                else if (x == null)
                {
                    continue;
                }
            }

            return newArray;
        }

    }
}