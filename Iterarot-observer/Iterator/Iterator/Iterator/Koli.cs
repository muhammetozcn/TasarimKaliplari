using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Koli
    {
        public CipsTuru cipsturu { get; set; }
        public int birKoliCipsmiktar { get; set; }
 
        public Koli()
        {
            this.cipsturu = new CipsTuru();
         
            this.birKoliCipsmiktar = 10;

        }
        public Koli(string marka,int gramaj,string tur,int miktar)
        {
            this.cipsturu = new CipsTuru(marka,gramaj,tur);
            this.birKoliCipsmiktar = miktar;
        }

      
    }
    public class CipsTuru
    {
        public string Marka { get; set; }
        public string tur { get; set; }
        public int gramaj { get; set; }

        public CipsTuru()
        {
            this.Marka = "Amigo";
            this.gramaj = 108;
            this.tur = "Taco Baharatlı";
        }
        public CipsTuru(string marka,int gramaj,string tur)
        {
            this.gramaj = gramaj;
            this.Marka = marka;
            this.tur = tur;
        }

        public override string ToString()
        {
            return "" + this.Marka + "-" + this.tur + "-" + gramaj.ToString();
        }


    }
}
