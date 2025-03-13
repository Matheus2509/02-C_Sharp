using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classe
{
    static class StringExtensions
    {
        static public string Cut(this string thisOBJ, int cout)
        {
            if (thisOBJ.Length <= cout)
            {
                return thisOBJ;
            }
            else { 
                return thisOBJ.Substring(0, cout) +"...";
            }
        }
    }
}
