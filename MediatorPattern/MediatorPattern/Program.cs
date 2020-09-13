using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{

    //taş kağıt makas oyunu
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ali");
            User user2 = new User("Veli");
            Console.WriteLine("-------1.OYUN-----");

            Mediator mediator = new Mediator();
            mediator.Baslat(user);
            mediator.Baslat(user2);
            mediator.Oyna(user, degerler.Kağıt);
            mediator.Oyna(user2, degerler.Makas);
            Console.WriteLine("-------2.OYUN-----");

            User user3 = new User("Bahadır");
            User user4 = new User("Kahraman");
            Mediator mediator2 = new Mediator();
            mediator2.Baslat(user3);
            mediator2.Baslat(user4);
            mediator2.Oyna(user3, degerler.Taş);
            mediator2.Oyna(user4, degerler.Kağıt);
            Console.Read();
        }
    }
}
