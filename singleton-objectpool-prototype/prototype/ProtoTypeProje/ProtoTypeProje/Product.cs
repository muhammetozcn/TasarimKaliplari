using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeProje
{
    public class BarkodBilgisi
    {
        public int ID;
        public BarkodBilgisi(int ID)
        {
            this.ID = ID;
        }
    }
    public abstract class Product
    {
        public int id;
        public string type;
        public string marka;
        public string model;
        public int fiyat;
        public BarkodBilgisi barkodbilgisi;

        public abstract Product ShallowCopy();
        public abstract Product DeepCopy();



    }
}
