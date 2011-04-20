using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Gastro.logika
{
    public class Component
    {

        public string name;//{get; set;}

        [DisplayName("Nazwa produktu")]
         public string Name
         {
             get
             {
                 return name;
             }
         }
        [DisplayName("Ilość [x100g]")]
        public double count{get; set;}
        
        public Component(string name, double count)
        {
            this.name = name;
            this.count = count;
        }
    }

    class PotrawyLogic
    {
    }
}
