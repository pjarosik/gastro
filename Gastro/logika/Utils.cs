using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gastro.logika
{
    class Utils
    {
        public static List<object> dataFilter(String filter, List<object> data)
        {
            List<object> filterList = new List<object>();
            foreach (object obj in data)
            {
                if (obj.ToString().ToUpper().Contains(filter.ToUpper()))
                    filterList.Add(obj);
            }
            return filterList;
        }
    }
}
