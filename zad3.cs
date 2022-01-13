using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public static class Zad3
    {
        public static void Launch(string[] args)
        {
            try
            {
                throw new wyjatek1();
            }
            catch (wyjatek1 ne)
            {
                Console.WriteLine(ne);
                throw new wyjatek3("wyjatek1", ne);
            }
            catch (wyjatek3 de)
            {
                Console.WriteLine("Można");
            }
        }

    }
}
