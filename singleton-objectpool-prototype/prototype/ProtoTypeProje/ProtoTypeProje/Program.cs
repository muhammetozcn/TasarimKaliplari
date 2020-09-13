using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeProje
{
    class Program
    {
        public static void cizgiCiz()
        {
            Console.WriteLine("-------------------------");
        }
        static void Main(string[] args)
        {
            //1 bilgisayar 0 telefon
            ProductProto p1 = new ProductProto();
            p1.cacheDoldur();

            Console.WriteLine("----Cachedeki Urunler-----");
            p1.urunler.ForEach(item => Console.WriteLine(item.ToString()));
            cizgiCiz();

            Console.WriteLine("Bilgisayar Shallow Copy");

            Bilgisayar b1 =(Bilgisayar)p1.urunler[1].ShallowCopy();
            b1.barkodbilgisi.ID = 25;
            b1.marka = "Sony";
            b1.model = "Viao";
            cizgiCiz();
            p1.urunler.ForEach(item => Console.WriteLine(item.ToString()));
            Console.WriteLine(b1.ToString());
            cizgiCiz();

            Console.WriteLine("Telefon Deep Copy");

            Telefon t1 = p1.urunler[0].DeepCopy() as Telefon;
            t1.marka = "Vestel";
            t1.model = "Venus";
            t1.barkodbilgisi.ID = 35;
            Console.WriteLine(t1.ToString());
            p1.urunler.ForEach(item => Console.WriteLine(item.ToString()));





            Console.ReadLine();


        }
    }
}