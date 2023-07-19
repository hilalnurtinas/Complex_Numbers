using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyComplex
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
            Number n1 = new Number(5.0);
            Number n2 = new Number(3.0);
            
            MyComplex c1 = new MyComplex(n1, n2);

            Console.WriteLine(MyComplex.x + "-----" + c1.y);
            c1.Incredible();
            Console.WriteLine(MyComplex.x + "-----" + c1.y);

            MyComplex c2 = new MyComplex(n1, n2);

            Console.WriteLine(MyComplex.x + "-----" + c2.y);
            c2.Incredible();
            Console.WriteLine(MyComplex.x + "-----" + c2.y);

            //Console.WriteLine(c1.ToString());
            c1.KendiniTanit();
            c2.KendiniTanit();

            MyComplex c3 = c1 + c2;
            c3.KendiniTanit();

            MyComplex c4;
            c4 = c1.Topla(c3);
            c4.KendiniTanit();

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 == c3);    
        }
    }
}
