using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventofCode5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputData = File.ReadAllLines(@"C:\Users\nilss\Source\Repos\AdventOfCode\AdventOfCode5\AdventOfCode5\TestData.txt");

            var seatIdsArr = inputData.Select(i =>
            {
                var row = Convert.ToInt32(i.Substring(0, 7).Replace('B', '1').Replace('F', '0'), 2);
                var col = Convert.ToInt32(i.Substring(7, 3).Replace('R', '1').Replace('L', '0'), 2);
                return row * 8 + col;
            }).OrderBy(x => x).ToArray();

            Console.WriteLine($"Max: {seatIdsArr.Max()}");
            for (int i = 1; i < seatIdsArr.Length; i++)
            {
                if (seatIdsArr[i - 1] != seatIdsArr[i] - 1) Console.WriteLine($"Your seat: {seatIdsArr[i] - 1}");
            }
        }

        public static int GetRowNumber(string boardingPass)
        {
            int rowDivider = 64;
            int row = 0;

            for (int i = 0; i <= 6; i++)
            {
                if (boardingPass[i] == 'B')
                    row += rowDivider;

                rowDivider /= 2;
            }

            return row;
        }

        public static int GetColumnNumber(string boardingPass)
        {
            int colDivider = 4;
            int col = 0;

            for (int i = 7; i < boardingPass.Length; i++)
            {
                if (boardingPass[i] == 'R')
                    col += colDivider;

                colDivider /= 2;
            }
            return col;
        }
    }
}
