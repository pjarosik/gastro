using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace Gastro.logika
{
    class DBProvider
    {
        static LinqGastroDataContext cont = new LinqGastroDataContext();

        static private void myFunc()
        {
            var sel = from wit in cont.Witaminies
                      select wit.D;

            Witaminy wita = new Witaminy();
            wita.D = 0;
            cont.Witaminies.InsertOnSubmit(wita);
            cont.SubmitChanges();
        }
        static public bool addKwasyTluszczoweNasyc(Kw_tluszcz_nasyc newEntry)
        {
            cont.Kw_tluszcz_nasycs.InsertOnSubmit(newEntry);
            cont.SubmitChanges();
            return true;
        }
        static public bool addKwasyTluszczoweWielonienas(Kw_tluszcz_wielonienasyc newEntry)
        {
            cont.Kw_tluszcz_wielonienasycs.InsertOnSubmit(newEntry);
            cont.SubmitChanges();
            return true;
        }

        static public bool addKwasyTluszczoweJednonienas(Kw_tluszcz_jednonienasyc newEntry)
        {
            cont.Kw_tluszcz_jednonienasycs.InsertOnSubmit(newEntry);
            cont.SubmitChanges();
            return true; 
        }
        
        static public bool addSkladnikiMineralne(Skladniki_mineralne newEntry)
        {
            cont.Skladniki_mineralnes.InsertOnSubmit(newEntry);
            cont.SubmitChanges();
            return true;
        }

        static public bool addEnergia(Energia newEntry)
        {
            cont.Energias.InsertOnSubmit(newEntry);
            cont.SubmitChanges();

            return true;
        }
        static public bool addWitaminy(Witaminy newEntry)
        {
            cont.Witaminies.InsertOnSubmit(newEntry);
            cont.SubmitChanges();

            return true;
        }

        static public bool addWartoscEnergetyczna(Wartosc_energetyczna wartEn)
        {
            cont.Wartosc_energetycznas.InsertOnSubmit(wartEn);
            cont.SubmitChanges();
            return true;
        }
        
        static public bool addWeglowodany(Weglowodany wegl)
        {
            cont.Weglowodanies.InsertOnSubmit(wegl);
            cont.SubmitChanges();
            return true;
        }
        static public object getDatabaseData()
        {
            Table<Produkty> produkty = cont.GetTable<Produkty>();

            var allProdukty = from prod in produkty
                              select new
                              {
                                  prod.nazwa_produktu,
                                  prod.numer_kodowy
                              };

            return allProdukty;
        }

        static public bool addProdukty(Produkty newEntry)
        {
            cont.Produkties.InsertOnSubmit(newEntry);
            cont.SubmitChanges();
            return true;
        }


        static public bool addAminokwasy(Aminokwasy newEntry)
        {
            cont.Aminokwasies.InsertOnSubmit(newEntry);
            cont.SubmitChanges();

            return true;
        }

        static public void drop()
        {
            Produkty element;
            using (IEnumerator<Produkty> iterator = cont.Produkties.GetEnumerator())
            {
                for (int i = -1; i < cont.Produkties.Count(); i++)
                {
                    if (iterator.MoveNext())
                    {
                        element = iterator.Current;
                        Console.WriteLine("Kasuje: " + element.nazwa_produktu);
                    }
                }
            } 
            cont.Produkties.DeleteAllOnSubmit(cont.Produkties);
            cont.SubmitChanges();
        }
    }
}
