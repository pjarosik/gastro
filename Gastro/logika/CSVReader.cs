using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

namespace Gastro.logika
{
    class Fields
    {
        static public int[] aminokwasy = { 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81 };
        static public int[] energia = { 86, 87, 88, 89 };
        static public int[] kw_tluszcz_jednonienasyc = { 46, 47, 48, 49, 50, 51, 52, 53 };
        static public int[] kw_tluszcz_nasycone = { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };
        static public int[] kw_tluszcz_wielonienasyc = { 54, 55, 56, 57, 58, 59, 60, 61, 62 };
        static public int[] weglowowany = { 82, 83, 84, 85 };
        static public int[] witaminy = { 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33 };
        static public int[] skladniki_mineralne = { 13, 14, 15, 16, 17, 18, 19, 20, 21 };
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
        public static bool readFile(string path,BackgroundWorker worker)
        {
            float status = 0;
            string line = "";
            string[] splitedLine;

            int count = checkFileFormat(path); // checking file format
            long lines = countLinesInFile(path);
            lines -= count;
            float step = 100 / (float)lines;
            
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
                splitedLine = line.Replace("\"", "").Split(';');
                prepareProdukty(splitedLine);
                prepareAminokwasy(splitedLine);
                prepareWeglowodany(splitedLine);
                prepareKwasyTluszczoweJednonienas(splitedLine);
                prepareKwasyTluszczoweNasyc(splitedLine);
                prepareKwasyTluszczoweWielonienas(splitedLine);
                prepareSkladnikiMineralne(splitedLine);
                prepareWartoscEnergetyczna(splitedLine);
                prepareEnergia(splitedLine);
                prepareWitaminy(splitedLine);
                status += step;
                worker.ReportProgress((int)status);
                //Debug.WriteLine(splitedLine[86].ToString());
            }

            stream.Close();
            return true;
        }

        static long countLinesInFile(string f)
        {
            long count = 0;
            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                }
            }
            return count;
        }

        private static bool prepareWitaminy(string[] entryLine)
        {
            Witaminy wit = new Witaminy();
            wit.numer_kodowy = entryLine[1];

            wit.ek_retinolu = float.Parse(entryLine[Fields.witaminy[0]]);
            wit.retinol = float.Parse(entryLine[Fields.witaminy[1]]);
            wit.beta_karoten = float.Parse(entryLine[Fields.witaminy[2]]);
            wit.D = float.Parse(entryLine[Fields.witaminy[3]]);
            wit.E = float.Parse(entryLine[Fields.witaminy[4]]);
            wit.tiamina = float.Parse(entryLine[Fields.witaminy[5]]);
            wit.ryboflawina = float.Parse(entryLine[Fields.witaminy[6]]);
            wit.niacyna = float.Parse(entryLine[Fields.witaminy[7]]);
            wit.B6 = float.Parse(entryLine[Fields.witaminy[8]]);
            wit.foliany = float.Parse(entryLine[Fields.witaminy[9]]);
            wit.B12 = float.Parse(entryLine[Fields.witaminy[10]]);
            wit.C = float.Parse(entryLine[Fields.witaminy[11]]);
            DBProvider.addWitaminy(wit);
            return true;
        }
        private static bool prepareWartoscEnergetyczna(string[] entryLine)
        {
            Wartosc_energetyczna wartEn = new Wartosc_energetyczna();
            wartEn.numer_kodowy = entryLine[1];

            wartEn.KJ = Int32.Parse(entryLine[Fields.wartosc_energetyczna[0]]);
            wartEn.kcal = Int32.Parse(entryLine[Fields.wartosc_energetyczna[1]]);
            DBProvider.addWartoscEnergetyczna(wartEn);
            return true;
        }

        private static bool prepareSkladnikiMineralne(string[] entryLine)
        {
            Skladniki_mineralne sklMin = new Skladniki_mineralne();
            sklMin.numer_kodowy = entryLine[1];

            sklMin.sod = float.Parse(entryLine[Fields.skladniki_mineralne[0]]);
            sklMin.potas = float.Parse(entryLine[Fields.skladniki_mineralne[1]]);
            sklMin.wapn = float.Parse(entryLine[Fields.skladniki_mineralne[2]]);
            sklMin.fosfor = float.Parse(entryLine[Fields.skladniki_mineralne[3]]);
            sklMin.magnez = float.Parse(entryLine[Fields.skladniki_mineralne[4]]);
            sklMin.zelazo = float.Parse(entryLine[Fields.skladniki_mineralne[5]]);
            sklMin.cynk = float.Parse(entryLine[Fields.skladniki_mineralne[6]]);
            sklMin.miedz = float.Parse(entryLine[Fields.skladniki_mineralne[7]]);
            sklMin.mangan = float.Parse(entryLine[Fields.skladniki_mineralne[8]]);
            DBProvider.addSkladnikiMineralne(sklMin);
            return true;
        }

        private static bool prepareKwasyTluszczoweNasyc(string[] entryLine)
        {
            Kw_tluszcz_nasyc kw = new Kw_tluszcz_nasyc();
            kw.numer_kodowy = entryLine[1];

            kw.C4_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[0]]);
            kw.C6_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[1]]);
            kw.C8_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[2]]);
            kw.C10_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[3]]);
            kw.C12_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[4]]);
            kw.C14_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[5]]);
            kw.C15_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[6]]);
            kw.C16_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[7]]);
            kw.C17_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[8]]);
            kw.C18_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[9]]);
            kw.C20_0 = float.Parse(entryLine[Fields.kw_tluszcz_nasycone[10]]);
            DBProvider.addKwasyTluszczoweNasyc(kw);
            return true;
        }
        private static bool prepareKwasyTluszczoweWielonienas(string[] entryLine)
        {
            Kw_tluszcz_wielonienasyc kw = new Kw_tluszcz_wielonienasyc();
            kw.numer_kodowy = entryLine[1];

            kw.C18_2 = float.Parse(entryLine[Fields.kw_tluszcz_wielonienasyc[0]]);
            kw.C18_3 = float.Parse(entryLine[Fields.kw_tluszcz_wielonienasyc[1]]);
            kw.C18_4 = float.Parse(entryLine[Fields.kw_tluszcz_wielonienasyc[2]]);
            kw.C20_3 = float.Parse(entryLine[Fields.kw_tluszcz_wielonienasyc[3]]);
            kw.C20_4 = float.Parse(entryLine[Fields.kw_tluszcz_wielonienasyc[4]]);
            kw.C20_5 = float.Parse(entryLine[Fields.kw_tluszcz_wielonienasyc[5]]);
            kw.C22_5 = float.Parse(entryLine[Fields.kw_tluszcz_wielonienasyc[6]]);
            kw.C22_6 = float.Parse(entryLine[Fields.kw_tluszcz_wielonienasyc[7]]);
            DBProvider.addKwasyTluszczoweWielonienas(kw);
            return true;
        }

        private static bool prepareKwasyTluszczoweJednonienas(string[] entryLine)
        {
            Kw_tluszcz_jednonienasyc kw = new Kw_tluszcz_jednonienasyc();
            kw.numer_kodowy = entryLine[1];

            kw.C14_1 = float.Parse(entryLine[Fields.kw_tluszcz_jednonienasyc[0]]);
            kw.C15_1 = float.Parse(entryLine[Fields.kw_tluszcz_jednonienasyc[1]]);
            kw.C16_1 = float.Parse(entryLine[Fields.kw_tluszcz_jednonienasyc[2]]);
            kw.C17_1 = float.Parse(entryLine[Fields.kw_tluszcz_jednonienasyc[3]]);
            kw.C18_1 = float.Parse(entryLine[Fields.kw_tluszcz_jednonienasyc[4]]);
            kw.C20_1 = float.Parse(entryLine[Fields.kw_tluszcz_jednonienasyc[5]]);
            kw.C22_1 = float.Parse(entryLine[Fields.kw_tluszcz_jednonienasyc[6]]);
            DBProvider.addKwasyTluszczoweJednonienas(kw);
            return true;
        }
        private static bool prepareEnergia(string[] entryLine)
        {
            Energia energ = new Energia();
            energ.numer_kodowy = entryLine[1];

            energ.bialko = Int32.Parse(entryLine[Fields.energia[0]]);
            energ.tluszcz = Int32.Parse(entryLine[Fields.energia[1]]);
            energ.weglowodany = Int32.Parse(entryLine[Fields.energia[2]]);
            DBProvider.addEnergia(energ);
            return true;
        }

        private static bool prepareWeglowodany(string[] entryLine)
        {
            Weglowodany wegl = new Weglowodany();

            wegl.numer_kodowy = entryLine[1];
            wegl.sacharoza = double.Parse(entryLine[Fields.weglowowany[0]]);
            wegl.laktoza = double.Parse(entryLine[Fields.weglowowany[1]]);
            wegl.skrobia = double.Parse(entryLine[Fields.weglowowany[2]]);
            wegl.blonnik_pokarmowy = double.Parse(entryLine[Fields.weglowowany[3]]);
            DBProvider.addWeglowodany(wegl);
            return true;
        }

        private static bool prepareProdukty(string[] entryLine)
        {
            Produkty prod = new Produkty();

            prod.nazwa_produktu = entryLine[2];
            prod.numer_kodowy = entryLine[1];
            prod.odpadki = Int32.Parse(entryLine[Fields.odpadki]);
            prod.popiol = float.Parse(entryLine[Fields.popiol]);
            prod.tluszcz = float.Parse(entryLine[Fields.tluszcz]);
            prod.woda = float.Parse(entryLine[Fields.woda]);
            prod.choresterol = int.Parse(entryLine[Fields.choresterol]);
            prod.bialko_zwierzece = float.Parse(entryLine[Fields.bialko[0]]);
            prod.bialko_roslinne = float.Parse(entryLine[Fields.bialko[1]]);

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
