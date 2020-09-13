using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fritöz fritöz = new Fritöz();
            FırınKonveyor fırınKonveyor = new FırınKonveyor();
            PlastikKonveyor plastikKonveyor = new PlastikKonveyor();
            AromaMakinesi aromaMakinesi = new AromaMakinesi();
            AromaTamburu tambur = new AromaTamburu();
            MachineStatus status = new MachineStatus();

            fritöz.siradaki(fırınKonveyor);
            fırınKonveyor.siradaki(plastikKonveyor);
            plastikKonveyor.siradaki(aromaMakinesi);
           

            fritöz.check(status);

            Console.WriteLine("---------------------");

            aromaMakinesi.siradaki(tambur);
            fritöz.check(status);
            
            Console.WriteLine("---------------------");

            fırınKonveyor.siradaki(tambur);
            fritöz.check(status);




            Console.Read();

        }
    }
}
