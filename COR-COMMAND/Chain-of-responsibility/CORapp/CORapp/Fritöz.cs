using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORapp
{
    public class MachineStatus
    {
        public bool fritöz = true;
        public bool fırınKonveyor = true;
        public bool plastikKonveyor = true;
        public bool aromaMakinesi = false;
        public bool aromaTamburu = true;

    }
    public class Fritöz : Kontrol
    {
        public override void check(MachineStatus status)
        {
            if (status.fritöz)
            {
                Console.WriteLine("Fritöz   çalışıyor...");
            }
            else
            {
                Console.WriteLine("Alarm! Fritöz çalışmıyor");
            }
            this.nextControl(status);
        }
        public override void siradaki(Kontrol kontrol)
        {
            this.next = kontrol;
        }

    }

    public class FırınKonveyor : Kontrol
    {
        public override void check(MachineStatus status)
        {
            if (status.fırınKonveyor)
            {
                Console.WriteLine("Fırın konveyor çalışıyor...");
                this.nextControl(status);
            }
            else
            {
                Console.WriteLine("Alarm! Fırın konveyor çalışmıyor...");
            }
        }
        public override void siradaki(Kontrol kontrol)
        {
             this.next = kontrol;
        }
    }

    public class PlastikKonveyor : Kontrol
    {
        public override void check(MachineStatus status)
        {
            if (status.plastikKonveyor)
            {
                Console.WriteLine("Plastik konveyor çalışıyor...");
            }
            else
            {
                Console.WriteLine("Alarm! plastik konveyor çalışmıyor");
            }

    
            this.nextControl(status);

        }

        public override void siradaki(Kontrol kontrol)
        {
            this.next = kontrol;
        }
    }



    public class AromaMakinesi : Kontrol
    {
        public override void check(MachineStatus status)
        {
            if (status.aromaMakinesi)
            {
                Console.WriteLine("Aroma makinesi çalışıyor...");
            }
            else
            {
                Console.WriteLine("Alarm! Aroma makinesi çalışmıyor...");
            }
            this.nextControl(status);

        }

        public override void siradaki(Kontrol kontrol)
        {
            this.next = kontrol;
        }
    }
    
    public class AromaTamburu : Kontrol
    {
        public override void check(MachineStatus status)
        {
            if (status.aromaTamburu)
            {
                Console.WriteLine("Aroma Tamburu   çalışıyor...");
            }
            else
            {
                Console.WriteLine("Alarm!Aroma tamburu çalışmıyor...");
            }
            this.nextControl(status);

        }

        public override void siradaki(Kontrol kontrol)
        {
            this.next = kontrol;
        }
    }

}
