using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeProje
{
    public class KitapIcerik
    {
        public string KitapAdi;
        public string Yazar;
        public string YayinEvi;
    }
    [Serializable]
    public class Kitap
    {
        public KitapIcerik kitapicerik;
       
        public int KitapSayfaSayisi;
        public string KitapKategori;
        public string KitapBasimTarihi;

        public Kitap(string _kAdi, string _yazar,
            string _yayinevi, int _sayfaSayisi, string _kategori, string _basimTarih)
        {
            kitapicerik = new KitapIcerik();
            kitapicerik.KitapAdi = _kAdi;
            kitapicerik.Yazar = _yazar;
            kitapicerik.YayinEvi = _yayinevi;
            this.KitapSayfaSayisi = _sayfaSayisi;
            this.KitapKategori = _kategori;
            this.KitapBasimTarihi = _basimTarih;
        }

        public Kitap shallowCopy()
        {
            return this.MemberwiseClone() as Kitap;
        }
        public Kitap deepCopy()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;

                return (Kitap)formatter.Deserialize(ms);
            }



        }
    }
}
