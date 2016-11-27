using System;
using System.Runtime.InteropServices;

namespace Lab_4_oop_events
{
    delegate void DCoinThrow();

    class CoinThrower
    {
        public event DCoinThrow success = () => {};
        public event DCoinThrow failure = () => {};

        public void Throw(bool willBeTail)
        {
            var rnd = new Random();

            bool gotTail = rnd.Next(0, 2) == 0;
            if (gotTail == willBeTail) {
                success();
            } else {
                failure();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var coinThrower = new CoinThrower();
            coinThrower.success += () =>
                Console.WriteLine("Good Job you guessed!");
            coinThrower.failure += () =>
                Console.WriteLine("Ohhhhhh, you failed it!");

            for (var i = 0; i < 10; ++i)
            {
                Console.WriteLine("Do you think will be tail?(true or false)");
                var willBeTail = Convert.ToBoolean(Console.ReadLine());
                coinThrower.Throw(willBeTail);
            }
        }
    }
}