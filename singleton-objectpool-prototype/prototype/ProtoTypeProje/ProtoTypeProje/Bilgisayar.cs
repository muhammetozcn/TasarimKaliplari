using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeProje
{
    class Bilgisayar : Product
    {
        public Bilgisayar(int _id, string _marka, string _model, int _fiyat)
        {
            this.id = _id;
            this.type = "Bilgisayar";
            this.marka = _marka;
            this.model = _model;
            this.fiyat = _fiyat;
            this.barkodbilgisi = new BarkodBilgisi(10000);
           

        }
        public override Product DeepCopy()
        {
            Bilgisayar b1 = (Bilgisayar)this.MemberwiseClone();
            b1.barkodbilgisi = new BarkodBilgisi(this.barkodbilgisi.ID);
            return b1;
        }

        public override Product ShallowCopy()
        {
            return (Bilgisayar)this.MemberwiseClone();
        }

        public override string ToString()
        {
            string str = "Id:" + this.id + " Marka:" + this.marka
                + " Model:" + this.model + " Fiyat:" + this.fiyat
                + "  Barkod ID:" + this.barkodbilgisi.ID  ;

            return str;
        }
    }
}
