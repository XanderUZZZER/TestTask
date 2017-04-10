using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string");

            string temp = "Kharkiv=1431000, Kiev=2804000,Las Vegas=630211";
            string[] splittedString1 = temp.Split(',');  
                      
            City[] Cities = new City[splittedString1.Length];

            string[] splittedString2;
            for (int i = 0; i < splittedString1.Length; i++)
            {
                splittedString2 = splittedString1[i].Split('=');
                Cities[i].Name = splittedString2[0];
                Cities[i].Populatin = int.Parse(splittedString2[1]);
            }

            int LongestNameIndex = 0;
            int LongestName = Cities[0].Name.Length;
            int MostPopulatedIndex = 0;
            int MaxPopulation = Cities[0].Populatin;

            for (int i = 0; i < Cities.Length; i++)
            {
                if (Cities[i].Populatin > MaxPopulation)
                {
                    MostPopulatedIndex = i;
                    MaxPopulation = Cities[i].Populatin;
                }
                if (Cities[i].Name.Length > LongestName)
                {
                    LongestNameIndex = i;
                    LongestName = Cities[i].Name.Length;
                }
            }
            Console.WriteLine($"Most populated: {Cities[MostPopulatedIndex].Name} with {Cities[MostPopulatedIndex].Populatin}");
            Console.WriteLine($"Longest name: {Cities[LongestNameIndex].Name} ({Cities[LongestNameIndex].Name.Length} letters)");
            Console.ReadLine();
        }

        public struct City
        {
            public string Name;
            public int Populatin;
        }
    }
}
