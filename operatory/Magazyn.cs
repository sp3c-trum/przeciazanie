using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatory
{
    internal class Magazyn
    {
        public string Nazwa;
        public List<Produkt> listaProduktow = new List<Produkt>();

        public void wyswietlProdukty()
        {
            Console.WriteLine("Produkty:");
            for (int i = 0; i < listaProduktow.Count; i++)
            {
                Console.WriteLine(i + ". " + listaProduktow[i].nazwa);
            }
        }

        public void sortowanie()
        {
            for (int i = 0; i < listaProduktow.Count - 1; i++)
            {
                for(int j = 0; j < listaProduktow.Count - 1; j++)
                {
                    if (listaProduktow[j] > listaProduktow[j + 1])
                    {
                        var temp = listaProduktow[j];
                        listaProduktow[j] = listaProduktow[j + 1];
                        listaProduktow[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Posortowana tablica: ");
            wyswietlProdukty();
        }
    }
}
