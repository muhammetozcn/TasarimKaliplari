using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            Klima klima = new Klima("Toshiba");
            Kumanda kumanda = new Kumanda();
            Komut openButton = new PowerOn(klima);
            Komut offButton = new PowerOff(klima);
            Komut increaseTemp = new SicaklikArttir(klima);
            Komut decreaseTemp = new SicaklikAzalt(klima);

            kumanda.setTus(0, openButton);
            kumanda.setTus(1, offButton);
            kumanda.setTus(2, increaseTemp);
            kumanda.setTus(3, decreaseTemp);

            kumanda.komut[0].execute();
            Console.WriteLine("----------------");
            kumanda.komut[1].execute();
            Console.WriteLine("----------------");
            kumanda.komut[2].execute();
            Console.WriteLine("----------------");
            kumanda.komut[3].execute();

            Console.WriteLine("**********************");
            kumanda.komut[0].execute();
            Console.WriteLine("----------------");
            kumanda.komut[2].execute();
            Console.WriteLine("----------------");
            kumanda.komut[3].execute();


            Console.Read();
        }
    }
}
