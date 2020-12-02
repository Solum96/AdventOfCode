using System;
using System.IO;

namespace AdventOfCode2
{
    public class Program
    {
        //5-9 g: ggccggmgn
        static void Main(string[] args)
        {
            bool yolo = IsPasswordValid("1-3 g: rbggweg");

            var passwords = File.ReadAllLines(@"C:\Users\nilss\Source\Repos\AdventOfCode2\TestData.txt");
            int count = 0;
            foreach (var password in passwords)
            {
                if (IsPasswordValid(password)) count++;
            }
            Console.WriteLine(count);
        }

        public static bool IsPasswordValid(string input)
        {
            string[] data = input.Split(' ');
            if (data.Length != 3) throw new FormatException("Invalid string input");

            var span = data[0].Split('-');
            (var min, var max) = (int.Parse(span[0]), int.Parse(span[1]));

            var forcedLetter = data[1].Replace(":", "");

            int letterCount = 0;
            foreach (var item in data[2])
            {
                if (item.ToString() == forcedLetter) letterCount++;
            }


            return letterCount <= max && letterCount >= min;
            // Code challange 2
            //return (data[2].IndexOf(forcedLetter, min - 1) == min - 1 || data[2].IndexOf(forcedLetter, max - 1) == max - 1) &&
            //    !(data[2].IndexOf(forcedLetter, min - 1) == min - 1 && data[2].IndexOf(forcedLetter, max - 1) == max - 1);
        }
    }
}
