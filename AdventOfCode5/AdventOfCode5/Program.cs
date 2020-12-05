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

            List<int> seatIds = new List<int>();
            foreach (var item in inputData)
            {
                int row = GetRowNumber(item);
                int col = GetColumnNumber(item);

                seatIds.Add(row * 8 + col);
            }

            seatIds = seatIds.OrderBy(x => x).ToList();

            int answer = 0;
            for (int i = 1; i < seatIds.Count; i++)
            {
                if (seatIds[i - 1] != seatIds[i] - 1) answer = seatIds[i - 1] + 1;
            }

            Console.WriteLine("Highest seatID = " + seatIds.Max());
            Console.WriteLine("Your seat = " + answer);
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
