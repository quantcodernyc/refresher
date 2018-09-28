using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] iarray = new int[]{1, 2, 3, 4, 5, 6};
            int[] iarray = new int[] { -1, -2, -3, 0, 0, 3, 3, 4, 5, 6 };
            //int sum = 7;
            int sum = 3;
            findpairs(iarray, sum);
            Console.Read();
        }

        static void findpairs(int[] iarray,int sum)
        {
            HashSet<int> h = new HashSet<int>();
            for (int i = 0; i < iarray.Length; ++i)
            {
                int x = 0;
                if (iarray[i] < 0)
                { x = sum + iarray[i]; }
                else
                { x = sum - iarray[i]; }
                //if (h.Contains(x) && x >= 0)
                    if (h.Contains(x)) //takes care when integer array has negative values
                    { Console.WriteLine("Pair with given sum " + sum + " is (" + iarray[i] + ", " + x + ")");}
                h.Add(iarray[i]);
            }
        }
    }
}
