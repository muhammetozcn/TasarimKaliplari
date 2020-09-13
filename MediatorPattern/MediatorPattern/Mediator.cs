using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Mediator
    {
        public User[] user;
        public int userSayisi = 0;
        public int oynayanSayisi = 0;
        Game game;
        public Mediator()
        {
            user = new User[2];
        }

        bool userSayisiTamamMi(User user) => this.userSayisi < 2 && !this.user.Contains(user);
        public void Baslat(User user)
        {

            if (userSayisiTamamMi(user))
            {
                UserEkle(user);
            }
            else
            {
                Console.WriteLine("Sunucu->Kullanici Sayisi doldu");
            }
            UserSayisiKontrol();
        }
        private void UserEkle(User user)
        {
            this.user[this.userSayisi] = user;
            Console.WriteLine("Sunucu -> Kullanıcı eklendi:" + user.Name);
        }

        private void UserSayisiKontrol()
        {
            if (userSayisi == 1)
            {
                Console.WriteLine("--------Oyun başladı--------");
                game = new Game(user[0], user[1]);
            }
            if (userSayisi < 1)
            {
                userSayisi++;
            }

        }
        public void Oyna(User user, degerler d1)
        {
            if (checkUser(user))
            {
                user.kullaniciSecim = d1;
                Console.WriteLine(user.Name + ":" + d1.ToString() + " Oynadı");
                oynayanSayisi++;
                if (oynayanSayisi == 2)
                {
                    game.kazananKontrolu(this.user[0], this.user[1]);
                }
            }
            else
            {
                Console.WriteLine("Lütfen oyunu başlatınız...");
            }

        }
        bool checkUser (User user) =>  this.user.Contains(user);
    }
    
}
