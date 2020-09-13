using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public enum degerler
    {
        Taş, Kağıt, Makas
    }
    public  class User
    {
        public string Name;

        public degerler kullaniciSecim;
        public User(string name)
        {
            this.Name = name;
        }

        public void EkranaYaz(string Name)
        {
            if (Name.Equals(""))
            {
                Console.WriteLine(this.Name + "'in Ekranı-> BERABERE!" + Name);

            }
            else
            {
                Console.WriteLine(this.Name + "'in Ekranı-> KAZANAN:" + Name);
            }
        }
    }
}
