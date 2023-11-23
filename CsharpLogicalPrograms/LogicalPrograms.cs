using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    internal class LogicalPrograms
    {
        static int i = 2;
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            int left = 0;
            int right = charArray.Length - 1;

            while (left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                left++;
                right--;
            }

            return new string(charArray);
        }

        public bool IsPalindrome(string input)
        {
            // Convert the input string to lowercase and remove spaces
            input = input.ToLower().Replace(" ", "");

            // Compare the string with its reverse
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public bool IsPrimeNumber(string input)
        {
            int.TryParse(input, out int n);
            // corner cases
            if (n == 0 || n == 1)
            {
                return false;
            }

            // Checking Prime
            if (n == i)
                return true;

            // base cases
            if (n % i == 0)
            {
                return false;
            }
            i++;
            return IsPrimeNumber(n.ToString());
        }

        public void PyramidPattern()
        {
            int NoOfrows = 5;
            for (int rows = 1; rows < NoOfrows; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void RightTrianglePattern()
        {
            int rows = 4;
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern()
        {
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine(" ");
            }
        }


        public long Factorial(int num)
        {
            long Factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                Factorial *= i;
            }

            return Factorial;
        }


        public static IEnumerable<char> Duplicate(string input)
        {
            var charCount = new Dictionary<char, int>();
            foreach (var character in input)
            {
                if (charCount.ContainsKey(character))
                {
                    charCount[character]++;
                }
                else
                {
                    charCount[character] = 1;
                }
            }

            foreach (var pair in charCount)
            {
                if (pair.Value > 1)
                {
                    yield return pair.Key;
                }
            }
        }

        public static IEnumerable<char> DuplicatesWithLinq(string input)
        {
            var groups = input.GroupBy(c => c);
            return groups.Where(g => g.Count() > 1).Select(g => g.Key);
        }

        public static void swappingWithouTemp()
        {
            int a = 10;
            int b = 5;

            a = a + b; //a=15
            b = a - b;//b=10
            a = a - b;//a=5

        }

        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap if the element found is greater than the next element
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }

        public void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
