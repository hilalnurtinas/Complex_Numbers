using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplex
{
    public class MyComplex
    {
        private Number real;
        private Number imaginal;

        public static int x = 1;
        public int y = 1;

        public void Incredible()
        {
            x++;
            y++;
        }

        //parametrenin olması bunun imzası(ayırt edici özelliği), yani bu çağırılır
        public MyComplex(Number real, Number imaginal)
        {
            this.real = real;   
            this.imaginal = imaginal;
        }

        //parametrenin olmaması bunun imzası, yani bu çağırılır
        public MyComplex()
        {
            this.real = new Number(0);
            this.imaginal = new Number(0);
        }

        public Number Real { get => real; set => real = value; }
        public Number Imaginal { get => imaginal; set => imaginal = value; }

        public void KendiniTanit()
        {
            Console.WriteLine(this.ToString());
        }
        //tostring metodu c#ta var ve bu fonksiyonu kullanmak için override ederek bu metodda değişiklik yapabiliyoruz
        public override string ToString()
        {
            return this.real.Sayi + " + " + this.imaginal.Sayi + "i";
        }

        //overload yapabilmek için operator +() kullandık ve overload sayesinde operatore yani +'ya anlam kattık.
        //böylece toplama işlemi gerçekleşmiş oluyor

        //MyComplex tipinde "c" değişkeni döndürüleceği için MyComplex yazıldı  (MyComplex: return type)
        public static MyComplex operator +(MyComplex c1, MyComplex c2)
        {
            MyComplex c = new MyComplex();
            c.real.Sayi = c1.real.Sayi + c2.real.Sayi;
            c.imaginal.Sayi = c1.imaginal.Sayi + c2.imaginal.Sayi;

            return c;
        }

        //overload yerine bu şekilde fonk tanımlayarak da toplama işlemi gerçekleştirilebilir
        public MyComplex Topla(MyComplex c)
        {
            MyComplex C = new MyComplex();
            C = this + c;
            //buradaki this
            //private Number real;
            //private Number imaginal;
            //değişkenlerini çağırıyor
            return C;
        }

        //overload işlemi gerçekleştirerek =='e yeni bir anlam ekledik
        //bool tipinde değişken döndürüleceği için bool yazıldı  (bool: return type)
        public static bool operator ==(MyComplex c1, MyComplex c2)
        {
            return(c1.real.Sayi == c2.real.Sayi && c1.imaginal.Sayi == c2.imaginal.Sayi);
        }

        public static bool operator !=(MyComplex c1, MyComplex c2)
        {
            return !(c1 == c2);
        }

    }
}
