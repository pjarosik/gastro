using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Gastro.logika
{
    public class Component
    {
         [DisplayName("Nazwa produktu")]
        public string name{get; set;}

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
