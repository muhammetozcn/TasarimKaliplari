using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeProje
{
    class Telefon : Product
    {
        public Telefon(int _id,string _marka,string _model,int _fiyat)
        {
            this.id = _id;
            this.type = "Telefon";
            this.marka = _marka;
            this.model=_model;
            this.fiyat=_fiyat;
            this.barkodbilgisi = new BarkodBilgisi(90000);
        }
        public override Product DeepCopy()
        {
            Telefon t1=(Telefon)this.MemberwiseClone();
            t1.barkodbilgisi = new BarkodBilgisi(this.barkodbilgisi.ID);
            return t1;
            
        }

        public override Product ShallowCopy()
        {
            return (Telefon)this.MemberwiseClone();
        }

        public override string ToString()
        {
            string str = "Id:" + this.id + " Marka:" + this.marka
                 + " Model:" + this.model + " Fiyat:" + this.fiyat
                 + "  Barkod ID:" + this.barkodbilgisi.ID;

            return str;
        }
    }
}
