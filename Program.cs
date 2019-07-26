using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            //var thStrings = words.Where(w => w.Contains("th"));

            //foreach (var word in thStrings)
            //{
            //    Console.WriteLine(word);               
            //}
            //Console.ReadLine();
            //-----------------------------------------------------------------------------------------------------------
            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            //var noDupes = names.Distinct();

            //foreach (var name in noDupes)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();
            //-----------------------------------------------------------------------------------------------------------
            //List<string> classGrades = new List<string>()
            //{
            //    "80,100,92,89,65",
            //    "93,81,78,84,69",
            //    "73,88,83,99,64",
            //    "98,100,66,74,55"
            //};

            //var AllClassAvg = classGrades.Average(g => g.Split(',').ToList().ConvertAll(Convert.ToInt32).OrderBy(m => m).ToList().Skip(1).Average());

            //Console.WriteLine(AllClassAvg);
            //Console.ReadLine();
            //-----------------------------------------------------------------------------------------------------------
            //string name = "Terrill";

            //var alphaOrderedString = name.GroupBy(n => n).ToDictionary(grp => grp.Key, grp => grp.Count()).Select(x => x.Key + "" + x.Value).OrderBy(n => n).Aggregate((s1, s2) => s1 + s2).ToUpper();          

            //Console.WriteLine(alphaOrderedString);
            
            //Console.ReadLine();
        }
    }
}
