using operatory;

Produkt produkt = new Produkt();
Produkt produkt2 = new Produkt();
Produkt produkt3 = new Produkt();
Produkt produkt4 = new Produkt();
produkt++;
produkt++;
produkt--;
produkt.cena = 100;
produkt2.cena = 200;
produkt3.cena = 150;
produkt4.cena = 50;

produkt.nazwa = "Produkt 1";
produkt2.nazwa = "Produkt 2";
produkt3.nazwa = "Produkt 3";
produkt4.nazwa = "Produkt 4";

Console.WriteLine(produkt.ilosc);
Console.WriteLine(produkt2.ilosc);
Console.WriteLine(produkt > produkt2);
Console.WriteLine(produkt != produkt2);

Magazyn magazyn = new Magazyn();
magazyn.listaProduktow.Add(produkt);
magazyn.listaProduktow.Add(produkt2);
magazyn.listaProduktow.Add(produkt3);
magazyn.listaProduktow.Add(produkt4);
magazyn.wyswietlProdukty();
magazyn.sortowanie();