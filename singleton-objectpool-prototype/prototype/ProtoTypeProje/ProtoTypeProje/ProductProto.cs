using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeProje
{
    public class ProductProto
    {
        public  List<Product> urunler;
        public ProductProto()
        {
            urunler = new List<Product>();
        }
        
        public  void cacheDoldur()
        {
            Telefon telefon = new Telefon(100,"Samsung","S7",2500);
            this.urunler.Add(telefon);
            Bilgisayar bilgisayar = new Bilgisayar(105, "Asus", "GL553VD", 4500);
            urunler.Add(bilgisayar);
        }

    
    }
}
