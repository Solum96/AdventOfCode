using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode6
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputData = File.ReadAllText(@"C:\Users\nilss\Source\Repos\AdventOfCode\AdventOfCode6\AdventOfCode6\TestData.txt").Split(Environment.NewLine + Environment.NewLine);
            var inputArr = inputData.Select(i => i.Split(Environment.NewLine)).ToArray();

            var partOne = inputArr
                            .Select(group => group
                                .SelectMany(i => i)
                                .Distinct()
                                .Count()
                            ).Sum();

            var partTwo = inputArr
                            .Select(group => group
                                .SelectMany(i => i)
                                .Distinct()
                                .Where(x => group
                                    .All(y => y
                                    .Contains(x)))
                                .Count()
                            ).Sum();

            Console.WriteLine(partOne);
            Console.WriteLine(partTwo);
        }
    }
}
