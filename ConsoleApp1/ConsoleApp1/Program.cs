using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = System.IO.File.ReadAllText("../../tekst.txt");

            int mittusona = (from word in tekst.Substring(0) select word).Count();
            Console.WriteLine("tekstifailis on "+ mittusona + " sõna");

            int mittu_tähte = (from char1 in tekst.ToList().Distinct()where tekst !=" " select char1).Count();
            Console.WriteLine("tekstis on "+mittu_tähte+" erinevat tähemärki");

            char[] kõiktähed = (from char1 in tekst.ToList().Distinct() where tekst != " " where tekst != "" select char1).ToArray();

            var sort = from s in kõiktähed orderby s select s;

            foreach (var item in sort)
            {
                int mittutähte = (from char1 in tekst.ToList() where char1 == item select char1).Count();
                Console.WriteLine(item+ " = "+ mittutähte);
            }
            string[]words = tekst.Split(new char[] { ' '},
                StringSplitOptions.RemoveEmptyEntries);
            var word_query =
                (from string word in words
                orderby word
                select word).Distinct();
            string[] words1 = word_query.ToArray();
            foreach (var item in words1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
