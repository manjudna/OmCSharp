using System;

namespace OmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsPalindrome("A man a plan a canal Panama"));

            Console.WriteLine(SquareRoot(81));

            Console.WriteLine(GetNthFibonacci(13));

            SortInts(new int[] { 9, 12, 4, 7, 8, 11, -4 });

            Console.ReadLine();
        }

        // Sort
        //Given an array of unsorted integers, write a function that will sort the array with the smallest integer at the start, and the largest at the end.Please don’t use a standard library function for this.
        //Example:
        //Input: [9, 12, 4, 7, 8, 11], Output: [4, 7, 8, 9, 11, 12]
        private static void SortInts(int[] arr)
        {

            int temp;

            // traverse 0 to array length
            for (int i = 0; i < arr.Length - 1; i++)

                // traverse i+1 to array length
                for (int j = i + 1; j < arr.Length; j++)

                    // compare array element with 
                    // all next element
                    if (arr[i] > arr[j])
                    {

                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }

        //Fibonacci
        //Write a function that calculates the nth value of the Fibonacci sequence
        //The Fibonacci sequence is a sequence where each value is the sum of the 2 previous values. 
        //E.g.fib(10) = fib(8) + fib(9)
        //Examples:
        //Input: 4, Output: 3
        //Input: 13, Output: 233

        public static int GetNthFibonacci(int n)
        {
            //int number = n - 1; 
            int number = n;
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }




        //Palindromes
        //Write a function that takes a string and determines if It is a palindrome.A palindrome is a string which is the same forwards as it is backwards.The function should ignore whitespace and casing.
        //Examples:
        //Input: “racecar”, Output: true
        //Input: “laptop”, Output: false
        //Input: “A man a plan a canal Panama”, Output: true (notice the whitespace & casing!)
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];

                // Scan forward for a while invalid.
                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    a = value[min];
                }

                // Scan backward for b while invalid.
                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    b = value[max];
                }

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }



        //Square Root with no Math functions
        //Write a function that will calculate the square root of an integer.The answer should be accurate to 1 decimal place. You are not allowed to use any Math functions or libraries.
        //Examples:
        //Input: 9, Output: 3
        //Input: 60, Output: 7.74…
        //Input 1000, Output: 31.62…
        static string SquareRoot(double number)
        {
            double precision = 0.0001; 
            double s = number;

            while ((s - number / s) > precision)
            {
                s = (s + number / s) / 2;
            }
            var value =  String.Format("{0:0.00}", s);
            return value;
        }
       
    }
}
