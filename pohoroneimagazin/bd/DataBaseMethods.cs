using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace pohoroneimagazin.bd
{
    internal class DataBaseMethods
    {
        public static List<cenapamatnika> Cenaps()
        {
            var stud = new MongoClient("mongodb://localhost");
            var database = stud.GetDatabase("shop");
            var collection = database.GetCollection<cenapamatnika>("cena");
            return collection.Find(x => true).ToList();
        }
        public static List<regnov> Authorizations()
        {
            var auth = new MongoClient("mongodb://localhost");
            var database = auth.GetDatabase("shop");
            var collection = database.GetCollection<regnov>("regnov1");
            return collection.Find(x => true).ToList();
        }
        public static void AddClientToDatabase(regnov regnov)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("shop");
            var collection = database.GetCollection<bd.regnov>("regnov1");
            collection.InsertOne(regnov);
        }
    }
}
