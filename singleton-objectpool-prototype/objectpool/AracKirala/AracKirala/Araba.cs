using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKirala
{
    public class Araba
    {
        public string aracSahibi { get; set; } = "";

        public int id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string ModelYili { get; set; }
        public int fiyat { get; set; }
        public Araba(int _id,string _marka,string _model,string _modelYili,int _fiyat)
        {
            this.id = _id;
            this.Marka = _marka;
            this.Model = _model;
            this.ModelYili = _modelYili;
            this.fiyat = _fiyat;

        }

       
    }
}
