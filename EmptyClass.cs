using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplex
{
    public class Number
    {
        double sayi;

        public Number(double sayi)
        {
            this.sayi = sayi;
        }
        public double Sayi { get => sayi; set => sayi = value; }



    }
}
