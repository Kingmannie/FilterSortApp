
namespace FilterSortApp
{
    //Single Responsibility, Filter represents filter result of string array param.
    public class Filter
    {
        public string[] filter_action(string[] filterArray)
        {
            for (int x = 2; x < filterArray.Length; x++)
            {
                bool flagPrimeNum = true;

                for (var y = 2; y < x; y++)
                {
                    if (x % y == 0)
                    {
                        flagPrimeNum = false;
                        break;
                    }

                }

                if (flagPrimeNum)
                {
                    filterArray[x] = null;
                }
            }

            return filterArray;
        }

    }

}