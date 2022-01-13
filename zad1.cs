using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public static class Zad1
    {
        public static void PrintStrLength(string str)
        {
            Console.WriteLine(str.Length);
        }

        public static void Launch(string[] args)
        {
            try
            {
                PrintStrLength(null);
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.StackTrace);
                throw new Exception("Podano null", nre);
            }
        }
    }
}