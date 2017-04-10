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

            string temp = "Kharkiv=1431000, Kiev=2804000,LasVegas=630211";

            string[] string1 = temp.Split(',');            
            City[] Cities = new City[string1.Length];

            string[] string2;
            for (int i = 0; i < string1.Length; i++)
            {
                string2 = string1[i].Split('=');
                Cities[i].Name = string2[0];
                Cities[i].Populatin = int.Parse(string2[1]);
            }

            int LongestCityNameIndex = 0;
            int LongestCityName = Cities[0].Name.Length;
            int MostPopulatedIndex = 0;
            int MaxPopulation = Cities[0].Populatin;

            for (int i = 0; i < Cities.Length; i++)
            {
                if (Cities[i].Populatin > MaxPopulation)
                {
                    MostPopulatedIndex = i;
                    MaxPopulation = Cities[i].Populatin;
                }
                if (Cities[i].Name.Length > LongestCityName)
                {
                    LongestCityNameIndex = i;
                    LongestCityName = Cities[i].Name.Length;
                }
            }
            Console.WriteLine($"Most populated: {Cities[MostPopulatedIndex].Name} with {Cities[MostPopulatedIndex].Populatin}");
            Console.WriteLine($"Longest name: {Cities[LongestCityNameIndex].Name} ({Cities[LongestCityNameIndex].Name.Length} letters)");
            Console.ReadLine();
        }

        public struct City
        {
            public string Name;
            public int Populatin;
        }
    }
}
