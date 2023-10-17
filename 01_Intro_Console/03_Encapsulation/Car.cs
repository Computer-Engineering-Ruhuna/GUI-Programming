using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulation
{
    public class Car
    {
        public string   Id{ get; set; }
        public string Color { get; set; }

        private double distance;

        public double Distance
        {
            get { return distance;}
            private set { distance = value; }
        }
    }
}
