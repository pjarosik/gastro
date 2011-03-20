using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace Gastro.logika
{
    class Fields
    {
        static public int[] aminokwasy = { 64, 81 };
        static public int[] energia = { 86, 89 };
        static public int[] kw_tluszcz_jednonienasyc = { 46, 53 };
        static public int[] kw_tluszcz_nasycone = { 41, 52 };
        static public int[] kw_tluszcz_wielonienasyc = { 54, 62 };
        static public int[] weglowowany = { 82, 85 };
        static public int[] witaminy = { 22, 33 };
        static public int[] skladniki_mineralne = { 13, 21 };
        static public int[] wartosc_energetyczna = { 4, 5 };
        static public int[] bialko = { 7, 8 };
        static public int choresterol = 63;
        static public int odpadki = 3;
        static public int woda = 6;
        static public int tluszcz = 10;
        static public int popiol = 12;
    }

    class CSVReader
    {
        /// <summary>
        /// Function reads data from file
        /// </summary>
        /// <param name="path">Path to file</param>
        /// <returns>Results: </returns>
        public static bool readFile(String path)
        {
            string line = "";
            string[] splitedLine;

            int count = checkFileFormat(path); // checking file format
            
            if (count == -1)
            {
                Debug.WriteLine("Incorrect file format.");
                return false;
            }

            StreamReader stream = new StreamReader(path);
            while (count != 0) { stream.ReadLine(); count--; } // cuting headers from file ( %count lines from the top of the file)
            
            while (!stream.EndOfStream && (line = stream.ReadLine()).Trim() != "")
            {
                // Here reading rows with data from file
                splitedLine = line.Split(';');
                prepareProdukty(splitedLine);
                //prepareAminokwasy(splitedLine);
                //Debug.WriteLine(splitedLine[86].ToString());
            }

            stream.Close();
            return true;
        }

        private static bool prepareProdukty(string[] entryLine)
        {
            Produkty prod = new Produkty();

            prod.nazwa_produktu = entryLine[2];
            prod.numer_kodowy = entryLine[1];
            prod.odpadki = Fields.odpadki;
            prod.popiol = Fields.popiol;
            prod.tluszcz = Fields.tluszcz;
            prod.woda = Fields.woda;
            prod.choresterol = Fields.choresterol;
            prod.bialko_zwierzece = Fields.bialko[0];
            prod.bialko_roslinne = Fields.bialko[1];

            DBProvider.addProdukty(prod);
            return true;
        }
        private static bool prepareAminokwasy(string[] entryLine)
        {
            int counter = Fields.aminokwasy[0];

            Aminokwasy amin = new Aminokwasy();
            amin.numer_kodowy = entryLine[1].ToString();

            amin.izoleucyna = Int32.Parse(entryLine[counter++]);
            amin.leucyna = Int32.Parse(entryLine[counter++]);
            amin.lizyna = Int32.Parse(entryLine[counter++]);
            amin.metionina = Int32.Parse(entryLine[counter++]);
            amin.cystyna = Int32.Parse(entryLine[counter++]);
            amin.fenyloalanina = Int32.Parse(entryLine[counter++]);
            amin.tyrozyna = Int32.Parse(entryLine[counter++]);
            amin.treonina = Int32.Parse(entryLine[counter++]);
            amin.tryptofan = Int32.Parse(entryLine[counter++]);
            amin.walina = Int32.Parse(entryLine[counter++]);
            amin.arginina = Int32.Parse(entryLine[counter++]);
            amin.histydyna = Int32.Parse(entryLine[counter++]);
            amin.alanina = Int32.Parse(entryLine[counter++]);
            amin.kwas_asparaginowy = Int32.Parse(entryLine[counter++]);
            amin.kwas_glutaminowy = Int32.Parse(entryLine[counter++]);
            amin.glicyna = Int32.Parse(entryLine[counter++]);
            amin.prolina = Int32.Parse(entryLine[counter++]);
            amin.seryna = Int32.Parse(entryLine[counter++]);

            DBProvider.addAminokwasy(amin);

            return true;
        }

        /// <summary>
        /// Function checks whether file has correct format
        /// </summary>
        /// <param name="path">Path to file on disk</param>
        /// <returns>Row in document indicates data to read </returns>
        private static int checkFileFormat(String path)
        {
            int row = -1;
            StreamReader stream = new StreamReader(path);
            while (!stream.EndOfStream)
            {
                row++;
                if (stream.ReadLine().Split(';')[0] == "1")
                {
                    stream.Close();
                    Debug.WriteLine("Data starting at " + row + " row.");
                    return row;
                }
            }
            stream.Close();
            return -1;
        }
    }
}
