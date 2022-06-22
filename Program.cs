using System;

namespace Generator_liczb_losowych
{
    class Program
    {
        public static int CheckIfInt(string valueAsString)
        {
            int valueAsInt;
            while (!int.TryParse(valueAsString, out valueAsInt))
            {
                Console.WriteLine("This is not a number!");
                valueAsString = Console.ReadLine();
            }
            return valueAsInt;
        }
        static void Main(string[] args)
        {
            int dices, rangeLow, rangeHigh;
            var rand = new Random();

            Console.WriteLine("Insert the number of dices: ");
            string dicesAsString = Console.ReadLine();
            dices = CheckIfInt(dicesAsString);

            Console.WriteLine("Insert the lower range: ");
            string rangeLowAsString = Console.ReadLine();
            rangeLow = CheckIfInt(rangeLowAsString);

            Console.WriteLine("Insert the higher range: ");
            string rangeHighAsString = Console.ReadLine();
            rangeHigh = CheckIfInt(rangeHighAsString);

            for (int i = 0; i < dices; i++)
            {
                Console.WriteLine(rand.Next(rangeLow, rangeHigh + 1));
            }
        }
    }
}
