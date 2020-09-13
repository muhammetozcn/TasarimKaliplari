using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Game
    {
        User user1;
        User user2;
        string KazananIsim = "";
        public Game(User user1, User user2)
        {
            this.user1 = user1;
            this.user2 = user2;
        }
      
        public void kazananKontrolu(User user1, User user2)
        {
            if (user1.kullaniciSecim == user2.kullaniciSecim)
            {
                Console.WriteLine("Sunucu-> Berabere");
            }

            bool userTasMiSecti(User user) => user.kullaniciSecim == degerler.Taş;
            bool userMakasMiSecti(User user) => user.kullaniciSecim == degerler.Makas;
            bool userKagitMiSecti(User user) => user.kullaniciSecim == degerler.Kağıt;

            if (userTasMiSecti(user1))
            {
                if (userMakasMiSecti(user2))
                {
                    KazananIsim = user1.Name;
                    Console.WriteLine("Sunucu->Kazanan:" + user1.Name);
                }
                else if (userKagitMiSecti(user2))
                {
                    KazananIsim = user2.Name;

                    Console.WriteLine("Sunucu->Kazanan:" + user2.Name);
                }
            }

            if (userKagitMiSecti(user1))
            {
                if (userMakasMiSecti(user2))
                {
                    KazananIsim = user2.Name;

                    Console.WriteLine("Sunucu->Kazanan:" + user2.Name);
                }
                else if (userTasMiSecti(user2))
                {
                    KazananIsim = user1.Name;

                    Console.WriteLine("Sunucu->Kazanan:" + user1.Name);
                }
            }

            if (userMakasMiSecti(user1))
            {
                if (userTasMiSecti(user2))
                {
                    KazananIsim = user2.Name;

                    Console.WriteLine("Sunucu->Kazanan:" + user2.Name);
                }
                else if (userKagitMiSecti(user2))
                {
                    KazananIsim = user1.Name;
                    Console.WriteLine("Sunucu->Kazanan:" + user1.Name);
                }
            }
            KazananıBildir();

        }
        private void KazananıBildir()
        {
            user1.EkranaYaz(KazananIsim);
            user2.EkranaYaz(KazananIsim);
        }
    }
}
