using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6
{
    [Serializable]
    public class Car
    {
        public string Name { get; set; }
        public string Firm { get; set; }
        public string Owner { get; set; }
        
        public Car()
        {

        }
        public Car(string name, string firm, string owner)
        {
            Name = name;
            Firm = firm;
            Owner = owner;
        }
    }
}
