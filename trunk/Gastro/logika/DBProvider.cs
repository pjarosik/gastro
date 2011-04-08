using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        static public bool addWitaminy(Witaminy newEntry)
        {
            cont.Witaminies.InsertOnSubmit(newEntry);
            cont.SubmitChanges();

            return true;
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
            cont.Dispose();
            cont = new LinqGastroDataContext();
        }

    }
}
