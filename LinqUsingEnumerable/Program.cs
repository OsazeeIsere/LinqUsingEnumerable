using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStriingOperators();
            QueryStringsWithEnumerableAndLamda();



        }

        private static void QueryStringsWithEnumerableAndLamda()
        {
            Console.WriteLine("Using Enumerable/Lamda expressions");
            string[] jwVideos = { "Lot Wife 2", "Hezekiah", "Real Love 1", "Josuah" };
            var subset = jwVideos.Where(vd => vd.Contains(" ")).OrderByDescending(vd => vd).Select(vd => vd);
            //print the subset
            foreach (var item in subset)
            {
                Console.WriteLine("Item: {0}", item);
            }
        }

        private static void QueryStriingOperators()
        {
            Console.WriteLine("Using Query Operators");
            string[] jwVideos = { "Lot Wife 2", "Hezekiah", "Real Love 1", "Josuah" };
            var subset = from vd in jwVideos where vd.Contains(" ") orderby vd descending select vd;
            //print the subset
            foreach(var item in subset)
            {
                Console.WriteLine("Item: {0}",item);
            }
        }

    }
}
