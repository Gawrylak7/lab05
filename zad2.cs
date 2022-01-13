using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public static class Zad2
    {
        public static void RandomException()
        {
            var random = new Random();
            int choice = random.Next(3);
            switch (choice)
            {
                case 0:
                    throw new wyjatek1();
                case 1:
                    throw new wyjatek2();
                case 2:
                    throw new wyjatek3();
            }
        }

        public static void Launch(string[] args)
        {
            try
            {
                RandomException();
            }
            catch (wyjatek1 ne)
            {
                Console.WriteLine("Wyrzucono wyjatek1");
            }
            catch (wyjatek2 ne)
            {
                Console.WriteLine("Wyrzucono wyjatek2");
            }
            catch (wyjatek3 de)
            {
                Console.WriteLine("Wyrzucono wyjatek3");
            }
        }
    }
}