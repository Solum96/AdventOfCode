using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode4
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllText(@"C:\Users\nilss\Source\Repos\AdventOfCode4\AdventOfCode4\TestData.txt");
            var passportArray = data.Split(Environment.NewLine + Environment.NewLine);

            List<Passport> passportList = new List<Passport>();
            foreach (var item in passportArray)
            {
                passportList.Add(new Passport(item));
            }

            int validCount = 0;
            foreach (var item in passportList)
            {
                if (item.BirthYear != null &&
                    item.IssueYear != null &&
                    item.ExpirationYear != null &&
                    item.Height != null &&
                    item.HairColor != null &&
                    item.EyeColor != null &&
                    item.PassportId != null
                    ) validCount++;
            }

            Console.WriteLine(validCount);
        }
    }
}
