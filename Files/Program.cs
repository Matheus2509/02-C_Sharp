using System.IO;
using System.Collections.Generic;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Celular");
            set.Add("Iphone");
            set.Add("Notebook");

            foreach (string s in set) {
                Console.WriteLine(s);
            }
            int o = 1;
            for (int i=0; i < 1;){
                o*=1000;
                if (o == 0) { 
                 o = 81;
                }
                Console.WriteLine(o);
            }

        }
    }
}