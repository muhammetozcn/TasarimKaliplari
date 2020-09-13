using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Iterator
{
    public class DepolamaMakine
    {
        BarkodOkuyucu barkodOkuyucu;

        public DepolamaMakine(Koli[]koliler)
        {
            this.barkodOkuyucu = new BarkodOkuyucu(koliler);
            while (barkodOkuyucu.isDone())
            {
                dbKaydet(barkodOkuyucu.currentItem());
                barkodOkuyucu.Next();
            }

        }


        public void dbKaydet(Koli koli)
        {
            const string connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("fabric");
            var collection = database.GetCollection<BsonDocument>("koliInfo");

            Console.WriteLine("DB kaydedildi:"+koli.cipsturu.ToString()+" miktar:"+koli.birKoliCipsmiktar);
            var doc = new BsonDocument
            {
                {"Date:",DateTime.Now },
                {"koliCipsMiktari",koli.birKoliCipsmiktar },
                {"koliCipsTuru",koli.cipsturu.ToBsonDocument() }
            };
            
            collection.InsertOne(doc);
            Console.WriteLine();
                
        }

    }
}
