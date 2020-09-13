using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {

        public  static void veriEkle(Koli[] koli)
        {
            PacketMachine machine = new PacketMachine();
            for (int i = 0; i < 5; i++)
            {
                koli[i] = machine.uret();

            }
            for (int i = 5; i < 10; i++)
            {
                koli[i] = machine.uret("Cipso",150,"Sade",12);

            }
            for (int i = 10; i < koli.Length; i++)
            {
                koli[i] = machine.uret("Çerezos",32,"Fıstıklı",60);

            }
        }
        static void Main(string[] args)
        {
            Koli[] koliler = new Koli[15];
            veriEkle(koliler);
            DepolamaMakine makine = new DepolamaMakine(koliler);
            Console.Read();


        }
    }
}
