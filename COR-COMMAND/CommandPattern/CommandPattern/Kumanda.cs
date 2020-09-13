using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Kumanda
    {
        static readonly int tus = 4;
        public Komut[] komut = new Komut[4];
        public Kumanda()
        {
            for (int i = 0; i < tus; i++)
            {
                komut[i] = new EmptyCommand();
            }

        }
        public void setTus(int tusNo, Komut command)
        {
            komut[tusNo] = command;
        }

        public void buttonWasPushed(int tusNo)
        {
            komut[tusNo].execute();
            Console.WriteLine("--------");
        }
    }
    public interface Komut
    {
        void execute();

    }
    public class EmptyCommand : Komut
    {
        public void execute()
        {
            Console.WriteLine("empty command");
        }
    }
    public class SicaklikArttir : Komut
    {
        private Klima klima;
        public SicaklikArttir(Klima klima)
        {
            this.klima = klima;
        }
        public void execute()
        {

            klima.IncreaseTemp();

        }


    }
    public class SicaklikAzalt : Komut
    {
        private Klima klima;
        public SicaklikAzalt(Klima klima)
        {
            this.klima = klima;

        }
        public void execute()
        {


            klima.DecreaseTemp();


        }


    }

    public class PowerOn : Komut
    {
        private Klima klima;

        public PowerOn(Klima klima)
        {
            this.klima = klima;
        }

        public void execute()
        {
            klima.On();
        }


    }
    public class PowerOff : Komut
    {
        private Klima klima;
        public PowerOff(Klima klima)
        {
            this.klima = klima;
        }

        public void execute()
        {
            klima.Off();
        }


    }

}
