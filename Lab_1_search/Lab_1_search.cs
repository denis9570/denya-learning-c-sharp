using System;
using System.Linq;

namespace Lab_1_search
{
    public class Lab1Search
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter array length ");
            var size = int.Parse(Console.ReadLine());
            var array = new int[size + 1]; // TODO huj zhopa pizda dzhigurda

            //заполнение массива случайными числами
            var random = new Random();
            for (var i = 0; i < size; ++i)
            {
                array[i] = random.Next(999);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Enter your key");
            var key = int.Parse(Console.ReadLine());

            array[size] = key;

            var j = -1;
            while (array[++j] != key) ;
            Console.WriteLine("Found: " + j);

            var hashTable = MakeHashTable(array);
            for (var i = 0; i < hashTable.Length; ++i)
            {
                Console.Write(hashTable[i].ToString() + " ");
            }
            Console.WriteLine();

            // seaching key in our array
            var k = -1;
            while (hashTable[(key + ++k) % hashTable.Length] != key) {
                Console.WriteLine(key + " " + k + " " + array[(key + k) % hashTable.Length]);
            };
            Console.WriteLine("Your key index " + ((key + k) % hashTable.Length) + " in " + (k + 1) + " iterations");
        }

        // Create Hash table from array
        private static int[] MakeHashTable(int[] array)
        {
            var flags = new bool[array.Length];
            var pointers = new int[array.Length];

            for (var i = 0; i < array.Length; ++i) {
                var x = array[i] % array.Length;

                while (flags[x++ % array.Length]);
                x = (x - 1) % array.Length;
                flags[x] = true;

                pointers[x] = array[i];
            }

            return pointers;
        }
    }
}