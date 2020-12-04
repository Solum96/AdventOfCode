using System;
using System.IO;
using System.Linq;

namespace AdventOfCode1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputString = File.ReadAllText("C:/Users/nilss/Source/Repos/AdventOfCode/AdventOfCode1/TestData.txt");
            var p = new Program();
            var answer = p.Find2020(p.CleanInputData(inputString));

            Console.WriteLine(answer[0] * answer[1] * answer[2]);
        }

        public int[] Find2020(int[] inData)
        {
            foreach (var item1 in inData)
            {
                foreach (var item2 in inData) 
                {
                    foreach (var item3 in inData)
                    {
                        if (item1 + item2 + item3 == 2020 && 
                            Array.IndexOf(inData, item1) != Array.IndexOf(inData, item2) &&
                            Array.IndexOf(inData, item2) != Array.IndexOf(inData, item3) &&
                            Array.IndexOf(inData, item3) != Array.IndexOf(inData, item1)) 
                            return new[] { item1, item2, item3 };
                    }
                }
            }
            return null;
        }

        public int[] CleanInputData(string inputData)
        {
            string[] arr = inputData.Split(Environment.NewLine);
            return Enumerable.Range(0, arr.Length).Select(i => int.Parse(arr[i].Trim())).ToArray();
        }
    }
}
