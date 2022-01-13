using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public static class Zad5_6
    {
        private class Osoba : ICloneable
        {
            public string? Nazwisko { get; set; }
            public string? Imie { get; set; }
            private int _nralbumu;

            public int NrAlbumu
            {
                get => _nralbumu;
                set => _nralbumu = Math.Abs(value);
            }

            public void Wypisz()
            {
                Console.WriteLine(Imie + " " + Nazwisko + " " + NrAlbumu);
            }

            public Osoba(string imie, string nazwisko, int nralbumu)
            {
                Imie = imie;
                Nazwisko = nazwisko;
                NrAlbumu = nralbumu;
            }

            public object Clone()
            {
                if (Imie == null || Nazwisko == null || NrAlbumu == 0)
                {
                    throw new ArgumentException("Null nie jest dozwolony");
                }

                return MemberwiseClone();
            }
        }

        public static void Launch(string[] args)
        {
            var os1 = new Osoba("Rafał", "Gawlak", 117795);
            var os2 = (Osoba) os1.Clone();
            os1.Wypisz();
            os2.Wypisz();
            os2.Imie = null;
            var os3 = (Osoba) os2.Clone();
            os3.Wypisz();
        }
    }
}