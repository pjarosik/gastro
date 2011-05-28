using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Diagnostics;

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
        static public List<object> getProdukty()
        {
            Table<Produkty> produkty = cont.GetTable<Produkty>();

            var allProdukty = from prod in produkty
                              select new
                               {
                                   prod.nazwa_produktu,//Substring(1,prod.nazwa_produktu.Length-2)
                                   prod.numer_kodowy
                               };
            return allProdukty.ToList<object>();
        }



        static public bool addProdukty(Produkty newEntry)
        {
            if (getIfExists(newEntry)==null)
            {
                cont.Produkties.InsertOnSubmit(newEntry);
                cont.SubmitChanges();
                return true;
            }
            else
                return false;
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
            cont.Skladniki_mineralnes.DeleteAllOnSubmit(cont.Skladniki_mineralnes);
            cont.Aminokwasies.DeleteAllOnSubmit(cont.Aminokwasies);
            cont.Energias.DeleteAllOnSubmit(cont.Energias);
            cont.Kw_tluszcz_jednonienasycs.DeleteAllOnSubmit(cont.Kw_tluszcz_jednonienasycs);
            cont.Kw_tluszcz_nasycs.DeleteAllOnSubmit(cont.Kw_tluszcz_nasycs);
            cont.Kw_tluszcz_wielonienasycs.DeleteAllOnSubmit(cont.Kw_tluszcz_wielonienasycs);
            cont.Wartosc_energetycznas.DeleteAllOnSubmit(cont.Wartosc_energetycznas);
            cont.Weglowodanies.DeleteAllOnSubmit(cont.Weglowodanies);
            cont.Witaminies.DeleteAllOnSubmit(cont.Witaminies);
            cont.Potrawies.DeleteAllOnSubmit(cont.Potrawies);
            cont.Skladnikis.DeleteAllOnSubmit(cont.Skladnikis);
            cont.Produkties.DeleteAllOnSubmit(cont.Produkties);
            //cont.Produkties.DeleteAllOnSubmit(cont.Produkties);
            cont.SubmitChanges();
        }

        static public List<object> getProductsName()
        {
            var productsName = from prod in cont.Produkties
                               select prod.nazwa_produktu;
                              //     new
                              //{
                              //    prod.nazwa_produktu,
                              //    prod.numer_kodowy
                              //};

            return productsName.ToList<object>();
        }

        static public List<object> getPotrawy()
        {
            var potrawy = from potr in cont.Potrawies
                          select new
                          {
                              potr.nazwa,
                              potr.kategoria,
                              potr.ID_potrawy
                          };

            return potrawy.ToList<object>();
        }



        static public Produkty getIfExists(Produkty prod)
        {
            var tmp = (from d in cont.Produkties
                      where ((d.numer_kodowy == prod.numer_kodowy) || d.nazwa_produktu == prod.nazwa_produktu)
                      select d).FirstOrDefault();

            return tmp;
        }

        static public List<object> getSkladniki(Potrawy potrawa)
        {
           
            var skladniki = from skl in cont.Skladnikis
                            from produkty in cont.Produkties
                            where (skl.ID_potrawy == potrawa.ID_potrawy && produkty.numer_kodowy == skl.ID_produktu)
                            select new
                            {
                                produkty.nazwa_produktu,
                                skl.ilosc
                            };
                
            return skladniki.ToList<object>();
        }

        static public List<Skladniki> getSkladnikiForPotrawa(Potrawy potrawa)
        {

            var skladniki = from skl in cont.Skladnikis
                            from produkty in cont.Produkties
                            where (skl.ID_potrawy == potrawa.ID_potrawy && produkty.numer_kodowy == skl.ID_produktu)
                            select skl;

            return skladniki.ToList<Skladniki>();
        }

        static public Skladniki getSkladnikForPotrawa(Potrawy potrawa, Skladniki skladnik)
        {

            var skladniki = from skl in cont.Skladnikis
                            from produkty in cont.Produkties
                             where ((produkty.numer_kodowy == skl.ID_produktu) && (skl.ID_potrawy == potrawa.ID_potrawy) && (skl.ID_produktu == skladnik.ID_produktu))
                            select skl;

            return skladniki.FirstOrDefault();
        }

        static public List<logika.Component> getComponents(Potrawy potrawa)
        {
            List<logika.Component> complist = new List<Component>();

               var skladniki = from skl in cont.Skladnikis
                            from produkty in cont.Produkties
                            where (skl.ID_potrawy == potrawa.ID_potrawy && produkty.numer_kodowy == skl.ID_produktu)
                            select new
                            {
                                produkty.nazwa_produktu,
                                skl.ilosc
                            };
                
            foreach (var obj in skladniki)
            {
                complist.Add(new Component(obj.nazwa_produktu, obj.ilosc));
            }

            return complist;
        }

        static public Potrawy getIfExists(Potrawy potr)
        {
            var tmp = (from d in cont.Potrawies
                      where ((d.nazwa == potr.nazwa) || d.ID_potrawy == potr.ID_potrawy)
                       select d).FirstOrDefault();

            return tmp;
        }

        //static public Skladniki getSkladnik(Potrawy potrawa, Skladniki skladnik)
        //{
        //    var skl = from skladnikidb in cont.Skladnikis
        //              from potrawydb in cont.Potrawies
        //              where ( (skladnikidb.ID_potrawy == potrawydb.ID_potrawy ) && 
        //              (skladnik.ID_produktu == skladnikidb.ID_produktu) )

        //}


        static public bool addOrUpdatePotrawa(Potrawy potrawa, List<Skladniki> skladniki)
        {
            Potrawy tmp_potrawa = getIfExists(potrawa);

            if (tmp_potrawa == null) // if potrawa does not exist in database
            {
                cont.Potrawies.InsertOnSubmit(potrawa);
                cont.SubmitChanges();

                foreach (Skladniki skladnik in skladniki)
                {
                    skladnik.ID_potrawy = potrawa.ID_potrawy;
                    cont.Skladnikis.InsertOnSubmit(skladnik);
                }
                cont.SubmitChanges();
            }
            else // if potrawa is going to be update
            {
                tmp_potrawa.kategoria = potrawa.kategoria;

                foreach (Skladniki skladnik in skladniki)
                {
                    Skladniki tmp_skladnik;
                    if ((tmp_skladnik = getSkladnikForPotrawa(tmp_potrawa, skladnik)) != null && tmp_skladnik.ilosc!=skladnik.ilosc)
                    {
                        tmp_skladnik.ilosc = skladnik.ilosc;
                        cont.SubmitChanges();
                    }
                    else if((tmp_skladnik = getSkladnikForPotrawa(tmp_potrawa, skladnik)) == null)
                    {
                        skladnik.ID_potrawy = tmp_potrawa.ID_potrawy;
                        cont.Skladnikis.InsertOnSubmit(skladnik);
                        cont.SubmitChanges();
                    }
                }

                List<Skladniki> listInDatabase;
                if ((listInDatabase = getSkladnikiForPotrawa(tmp_potrawa)).Count > skladniki.Count)
                {
                    foreach(Skladniki s in listInDatabase)
                    {
                        if (skladniki.Find(o => o.ID_produktu == s.ID_produktu) == null)
                        {
                            cont.Skladnikis.DeleteOnSubmit(s);
                            cont.SubmitChanges();
                        }
                    }
                }
            }
            return true;
        }

        static public bool removePotrawa(string potrawa_id)
        {
            Potrawy potrawa = new Potrawy();
            Potrawy potrawaToDelete;
            potrawa.ID_potrawy = int.Parse(potrawa_id);
            potrawaToDelete = getIfExists(potrawa);

            List<Skladniki> list;
            list = getSkladnikiForPotrawa(potrawa);

            foreach (Skladniki sklad in list)
            {
                cont.Skladnikis.DeleteOnSubmit(sklad);
                cont.SubmitChanges();
            }

            cont.Potrawies.DeleteOnSubmit(potrawaToDelete);
            cont.SubmitChanges();
            return true;
        }
        static public List<Potrawy> getPotrawaByCategory(string kategoria)
        {
            var tmp = (from d in cont.Potrawies
                       where (d.kategoria == kategoria)
                       orderby d.nazwa
                       select d).ToList<Potrawy>();

            return tmp;
        }

        static public bool checkIfJadlospisExist(string nazwa)
        {
            var tmp = from d in cont.Jadlospis
                      where (d.nazwa == nazwa)
                      select d;
            return tmp.Count() < 1 ? false : true;
        }

        static public bool AddJadlospis(Jadlospi jadlospis)
        {
            cont.Jadlospis.InsertOnSubmit(jadlospis);
            cont.SubmitChanges();

            return true;
        }
    }
}
