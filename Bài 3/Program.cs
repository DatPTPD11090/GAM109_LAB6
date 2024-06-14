using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>() { 5, 6, 7, 8, 9 };

            Console.WriteLine(" Union (Giam dan ) : ");

            var uniDescending = list1.Union(list2).OrderByDescending(x => x);
            foreach (var item in uniDescending)
            {
                Console.WriteLine(item + " ");
            }

            var concatAscending = list1.Concat(list2).OrderBy(x => x);
            foreach (var item in uniDescending)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine(" \n\nNgoai tru:");

            var except = list1.Except(list2);
            foreach (var item in except)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
