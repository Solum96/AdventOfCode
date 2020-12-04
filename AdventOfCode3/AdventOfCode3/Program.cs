using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines(@"C:\Users\nilss\Source\Repos\AdventOfCode3\AdventOfCode3\TestData.txt");
            var mapArray = CreateMap(data);
            var toboggan1 = new Toboggan() { xPosition = 0, yPosition = 0, TreeCount = 0 };
            var toboggan2 = new Toboggan() { xPosition = 0, yPosition = 0, TreeCount = 0 };
            var toboggan3 = new Toboggan() { xPosition = 0, yPosition = 0, TreeCount = 0 };
            var toboggan4 = new Toboggan() { xPosition = 0, yPosition = 0, TreeCount = 0 };
            var toboggan5 = new Toboggan() { xPosition = 0, yPosition = 0, TreeCount = 0 };

            foreach (var item in mapArray)
            {
                if (CalculateNextPosition(toboggan1, mapArray, 1, 1)) toboggan1.TreeCount++;
                if (CalculateNextPosition(toboggan2, mapArray, 1, 3)) toboggan2.TreeCount++;
                if (CalculateNextPosition(toboggan3, mapArray, 1, 5)) toboggan3.TreeCount++;
                if (CalculateNextPosition(toboggan4, mapArray, 1, 7)) toboggan4.TreeCount++;
                if (CalculateNextPosition(toboggan5, mapArray, 2, 1)) toboggan5.TreeCount++;
            }

            var answer = toboggan2.TreeCount;
            var answer2 = toboggan1.TreeCount * toboggan2.TreeCount * toboggan3.TreeCount * toboggan4.TreeCount * toboggan5.TreeCount;
            Console.WriteLine($"answer1 = {answer}");
            Console.WriteLine($"answer2 = {answer2}");
        }

        static bool CalculateNextPosition(Toboggan toboggan, string[][] map, int yMovement, int xMovement)
        {
            toboggan.xPosition += xMovement;
            toboggan.yPosition += yMovement;

            if (toboggan.xPosition >= map[0].Length) toboggan.xPosition -= (map[0].Length);

            try
            {
                return map[toboggan.yPosition][toboggan.xPosition] == "#";
            }
            catch
            {
                return false;
            }
        }

        static string[][] CreateMap(string[] data)
        {
            var dataList = new List<string[]>();
            foreach (var item in data)
            {
                char[] temp = item.ToCharArray();
                dataList.Add(temp.Select(i => i.ToString()).ToArray());
            }
            return dataList.ToArray();
        }
    }
}
