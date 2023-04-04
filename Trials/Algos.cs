using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trials
{
    public static class Algos
    {
        public static int[] sumOfN(int n)
        {
            int magnitude = Math.Abs(n);
            int factor = n < 0 ? -1 : 1;
            int[] result = new int[magnitude + 1];
            result[0] = 0;

            return Enumerable.Range(0, magnitude + 1).Select(num => (num * (num + 1) / 2) * factor).ToArray();

            //for (int i = 1; i <= magnitude; i++)
            //{
            //    result[i] = result[i - 1];
            //    result[i] += i * factor;

            //}
            //return result;


        }

    }

    // Create a function that will trim a string (the first argument given) if it is longer than the requested
    //maximum string length(the second argument given). The result should also end with "..."
    //These dots at the end also add to the string length.
    //For example, trim("Creating kata is fun", 14) should return "Creating ka..."
    //If the string is smaller or equal than the maximum string length, then simply return the string with no trimming or dots required.
    //e.g.trim("Code Wars is pretty rad", 50) should return "Code Wars is pretty rad"
    //If the requested string length is smaller than or equal to 3 characters, then the length of the dots is not added to the string length.
    //e.g.trim("He", 1) should return "H...", because 1 <= 3
    //Requested maximum length will be greater than 0. Input string will not be empty.




    public class TrimStringKata
    {
        public static string TrimString(string phrase, int len)
        {
            int p = phrase.Length;
            //second condition met
            if (p <= len)
            {
                return phrase;
            }
            //third condition met
            else if (len <= 3)
            {
                return phrase.Substring(0, len) + "...";
            }
            //first condition met
            else
            {
                return phrase.Substring(0, (len - 3)) + "...";
            }

        }
    }
}
