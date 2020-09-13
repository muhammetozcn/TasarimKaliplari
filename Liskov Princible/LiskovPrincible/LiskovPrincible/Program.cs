using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrincible
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekitap ekitap = new Ekitap( "Simyacı", "Paulo Coelho", "simyaci.epub", "epub");

            BasiliKitap basiliKitap = new BasiliKitap("Satranç","Stefan Zweig",70,"İş Bankası Kültür Yayınları",1000);

            BasiliKitapOperation operation = new BasiliKitapOperation();
            operation.Bastir(basiliKitap,2000);
            operation.Paketle(basiliKitap);
            operation.KargoyaVer(basiliKitap);

            Console.Read();
        }
    }

    public class Kitap
    {
        public int kitapId { get; set; }
        public string kitapAdi { get; set; }
        public string kitapYazari { get; set; }
        public Kitap(string kitapAdi, string kitapYazari)
        {
            this.kitapAdi = kitapAdi;
            this.kitapYazari = kitapYazari;

        }
    }
    public class Ekitap : Kitap
    {
        public Ekitap(string kitapAdi, string kitapYazari,string dosyaismi,string kitapformati) : base(kitapAdi, kitapYazari)
        {
            this.dosyaIsmi = dosyaismi;
            this.kitapFormati = kitapformati;
            Console.WriteLine(kitapAdi+" isimli  yazarı "+kitapYazari+" olan e-kitap oluşturuldu.Kitap Formatı:"+kitapformati+"'dır.");
        }
        public string dosyaIsmi { get; set; }
        public string kitapFormati { get; set; }
    }
    public class BasiliKitap : Kitap
    {
        public string yayinEvi { get; set; }
        public int sayfaSayisi { get; set; }
        public int stokSayisi { get; set; }
        public BasiliKitap(string kitapAdi, string kitapYazari,int sayfaSayisi,string yayinEvi,int stokSayisi) : base(kitapAdi, kitapYazari)
        {
            this.sayfaSayisi = sayfaSayisi;
            this.yayinEvi = yayinEvi;
            this.stokSayisi = stokSayisi;
            Console.WriteLine(kitapAdi + " isimli,kitabın  yazarı " + kitapYazari +" olan kitap "+ stokSayisi + "kadar stogu var.");
        }
    

    }
    public class BasiliKitapOperation
    {
        public void Bastir(BasiliKitap kitap,int sayi)
        {
            Console.WriteLine(sayi+" adet "+kitap.kitapYazari+" "+kitap.kitapAdi+" bastirildi.");
        }
        public void Paketle(BasiliKitap kitap)
        {
            Console.WriteLine(kitap.kitapAdi+" kitabı Paketlendi");
        }
        public void KargoyaVer(BasiliKitap kitap)
        {
            Console.WriteLine(kitap.kitapAdi+" kitabı Kargoya Verildi");
        }
    }


}
