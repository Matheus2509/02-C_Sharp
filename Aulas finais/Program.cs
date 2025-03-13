using System;
using System.Linq;

namespace Aulas
{
    class Program
    {
        static void Main(string[] args)
        {

            //data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Query

            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}