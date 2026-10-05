using System.Globalization;
using System.Text;

namespace Week7Assignment7._1
{
    internal class Program
    {

        static void SelectionSort(int[] numArray)
        {
            int minPosition, temp = 0;
            for(int i = 0; i < numArray.Length -1; i++)
            {
                minPosition = i;
                for (int j = i + 1; j < numArray.Length; j++)
                {
                    if (numArray[j] < numArray[minPosition])
                    {
                        minPosition = j;
                    }
                }
                if (minPosition != i)
                {
                    temp = numArray[i];
                    numArray[i] = numArray[minPosition];
                    numArray[minPosition] = temp;
                }
            }
        }

        static string MergedString(string str1, string str2)
        {
            StringBuilder output = new StringBuilder();
            int length = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < length; i++)
            {
                output.Append(str1[i]);
                output.Append(str2[i]);
            }
            if (str1.Length > length)
                output.Append(str1.Substring(length));
            else if (str2.Length > length)
                output.Append(str2.Substring(length));
            return output.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            int[] scores = { 90, 80, 95, 87, 86, 92, 75 };
            Console.WriteLine("Unsorted Scores:");
            Console.WriteLine(string.Join(", ", scores));
            SelectionSort(scores);
            Console.WriteLine("\nSorted Scores:");
            Console.WriteLine(string.Join(", ", scores));

            Console.WriteLine("\nPart 2");
            string str1 = "abc", str2 = "pqr", output;
            output = MergedString(str1, str2);
            Console.WriteLine($"String 1: {str1}");
            Console.WriteLine($"String 2: {str2}");
            Console.WriteLine($"Merged Output: {output}");

            str1 = "ab";
            str2 = "pqrs";
            output = MergedString(str1, str2);
            Console.WriteLine($"\nString 1: {str1}");
            Console.WriteLine($"String 2: {str2}");
            Console.WriteLine($"Merged Output: {output}");

        }
    }
}
