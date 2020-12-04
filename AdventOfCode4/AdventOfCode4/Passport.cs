using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdventOfCode4
{
    public class Passport
    {
        public int? BirthYear { get; set; }
        public int? IssueYear { get; set; }
        public int? ExpirationYear { get; set; }
        public string Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string PassportId { get; set; }
        public string CountryId { get; set; }

        public Passport(string passportData)
        {
            string[] separators = { Environment.NewLine, " ", "\t" };

            var dataArr = passportData.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in dataArr)
            {
                string decider = item.Substring(0, 3);
                switch (decider)
                {

                    case "byr":
                        int year = int.Parse(item.Substring(4));
                        if (year <= 2002 && year >= 1920) BirthYear = year;
                        else BirthYear = null;
                    break;

                    case "iyr":
                        year = int.Parse(item.Substring(4));
                        if (year <= 2020 && year >= 2010) IssueYear = year;
                        else IssueYear = null;
                    break;

                    case "eyr":
                        year = int.Parse(item.Substring(4));
                        if (year <= 2030 && year >= 2020) ExpirationYear = year;
                        else ExpirationYear = null;
                    break;

                    case "hgt":
                        string stringHeight = item.Replace("hgt:", "");
                        var heightInCm = 0;
                        var heightInIn = 0;
                        int.TryParse(stringHeight.Replace("cm", ""), out heightInCm);
                        int.TryParse(stringHeight.Replace("in", ""), out heightInIn);

                        if (heightInCm >= 150 && heightInCm <= 193) Height = stringHeight;
                        if (heightInIn >= 59 && heightInIn <= 76) Height = stringHeight;
                    break;

                    case "hcl":
                        string substring = item.Substring(4);
                        Match isValid = Regex.Match(substring.Substring(1), "[0-9a-fA-F]+");
                        if (substring[0] == '#' && isValid.Success && substring.Length == 7) HairColor = substring;
                    break;

                    case "ecl":
                        List<string> validEyeColors = new List<string>() { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
                        if (validEyeColors.Contains(item.Substring(4))) EyeColor = item.Substring(4);
                    break;

                    case "pid":
                        int pid = 0;
                        bool isOnlyNumbers = int.TryParse(item.Substring(4), out pid);
                        if (item.Substring(4).Length == 9 && isOnlyNumbers) PassportId = item.Substring(4);
                    break;

                    case "cid":
                        CountryId = item.Substring(4);
                    break;
                }

            }
        }
    }
}