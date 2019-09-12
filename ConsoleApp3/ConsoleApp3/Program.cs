using System;

namespace ConsoleApp3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           
            Console.Write("The array is :");
            foreach(int a in arr){
            Console.Write(a + ", ");
            }
           
            Console.WriteLine();
            Console.WriteLine("The Total of all the odd numbers is " + totalOdd(arr));


            Console.WriteLine("The total of the array is: " + totalArray(arr));

            string str = "Hello, World!";
            string temp = "";
            for(int i = str.Length; i > 0; i--)
            {
            temp += str[i - 1];
            }

            Console.WriteLine("\n" + temp);

            //This will remove any repeated occurrence of a letter, but the first time that a letter occurs it will be added to the new string.
            temp = "";
            foreach(char c in str)
            {
                if (!temp.Contains(c))
                {
                    temp += c;
                }
            }

            Console.WriteLine(temp + "\n");

          

            for(int i = 1; i <= 100; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }

        static int totalOdd(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    total += arr[i];
                }

            }
            return total;
        }

        static int totalArray(int[] arr)
        {
            int total = 0;
            foreach(int a in arr){ total += a; }

            return total;
        }


    }
}
