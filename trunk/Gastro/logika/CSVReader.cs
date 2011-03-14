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
                Debug.WriteLine(splitedLine.ToString());
            }

            stream.Close();
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
