using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;


namespace Lab2_DSA_sort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of elements(press 0 for default array):");
            int n = Convert.ToInt32(Console.ReadLine());

            // Creating random array
            int[] a;
            if (n == 0) a = GetRandomArray(6, 0);
            else
            {
                // Reading data to array
                a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write((i + 1) + ". ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

            }



            int[] b = new int[a.Length];
            Array.Copy(a, b, a.Length);
            Console.WriteLine("bubble sort: ");
            BubbleSort(b);
            Show(b);
            Console.WriteLine("Shell sort: ");
            ShellSort(a);
            Show(a);
            Console.ReadLine();
        }

        public static int BubbleSort(int[] intArray)
        {
            var counter = 0;
            Console.WriteLine("**********UnSorted Array********");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            for (int i = intArray.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    ++counter;
                    if (intArray[j] > intArray[j + 1])
                    {
                        int highValue = intArray[j];

                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = highValue;
                    }
                }
            }

            Console.WriteLine("**********Sorted Array********** " + counter);

            // ReSharper disable once EmptyForStatement
            for (int i = 0; i < intArray.Length; i++)
            {

            }

            return 0;
        }

        static void ShellSort(int[] array)
        {

            int i, j, increment, counter = 0;
            int temp;
            increment = array.Length / 2;
            while (increment > 0)
            {
                for (i = 0; i < array.Length; i++)
                {
                    j = i;
                    temp = array[i];
                    ++counter;
                    while ((j >= increment) && (array[j - increment].CompareTo( temp)>0))
                    {
                        ++counter;
                        array[j] = array[j - increment];
                        j = j - increment;
                    }
                    array[j] = temp;
                }
                if (increment == 2)
                    increment = 1;
                else
                    increment = increment * 5 / 11;

            }
           Console.WriteLine("Counter " + counter);
        }



        public static int[] GetRandomArray(int n, int startWith = 0)
        {
            Random random = new Random();
            int[] a = new int[n];
            for (int i = startWith; i < n; i++) a[i] = i;
            for (int i = 1; i < a.Length; i++)
            {
                int pos = random.Next(i + 1);
                int tmp = a[pos];
                a[pos] = a[i];
                a[i] = tmp;
            }
            return a;
        }



        static private void Show(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}


