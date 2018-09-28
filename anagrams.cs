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
            string text = System.IO.File.ReadAllText(@"C:\temp\sample.txt");
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n' , '\r'};
            string[] str = text.Split(delimiterChars,StringSplitOptions.RemoveEmptyEntries);

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of sample.txt = {0}", text);

            /*
             * In this solution creating hashmap for each word with key as sorted character array of word string, if key already exist means word is anagram.             
             */

            Dictionary<String, SortedSet<String>> dict = new Dictionary<String, SortedSet<String>>();
                for (int i = 0; i < str.Length ; i++)
                {
                    String s = str[i];
                    char[] c = s.ToCharArray();
                    Array.Sort(c);                
                    String tsorted = new String(c);
                    if (dict.ContainsKey(tsorted))
                        dict[tsorted].Add(s);
                    else
                    {
                        SortedSet<String> ss = new SortedSet<String>();
                        ss.Add(s);
                        dict.Add(tsorted, ss);                    
                    }
                }

            //printing output anagram sets per line from text block           
                foreach (var y in dict)
                    if (y.Value.Count > 1)
                    {
                        foreach (string s in y.Value)
                        { Console.Write("{0} ", s); }
                        Console.WriteLine();
                    }

            Console.Read();
        }
    }
}
