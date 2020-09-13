using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORapp
{

    public abstract class Kontrol
    {
        public Kontrol next;
        public abstract void check(MachineStatus status);
        public abstract void siradaki(Kontrol kontrol);
        public  void nextControl(MachineStatus status) {
            if (this.next != null)
            {
                this.next.check(status);
            }
        }

    }
}
