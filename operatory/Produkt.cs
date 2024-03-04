using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatory
{
    internal class Produkt
    {
        public string nazwa;
        public int cena;
        public int ilosc;

        public void showDane()
        {
            Console.WriteLine("Nazwa: " + nazwa + ", cena: " + cena + ", ilość: " + ilosc);
        }

        public static bool operator !=(Produkt produkt1, Produkt produkt2)
        {
            return produkt1.cena != produkt2.cena;
        }

        public static bool operator ==(Produkt produkt1, Produkt produkt2)
        {
            return produkt1.cena == produkt2.cena;
        }

        public static bool operator >(Produkt produkt1, Produkt produkt2)
        {
            return produkt1.cena > produkt2.cena;
        }

        public static bool operator <(Produkt produkt1, Produkt produkt2)
        {
            return produkt1.cena < produkt2.cena;
        }

        public static Produkt operator ++(Produkt produktIlosc)
        {
            produktIlosc.ilosc++;
            return produktIlosc;
        }

        public static Produkt operator --(Produkt produktIlosc)
        {
            produktIlosc.ilosc--;
            return produktIlosc;
        }
    }
}
