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
        public static List<avtorizatia> Authorizations()
        {
            var auth = new MongoClient("mongodb://localhost");
            var database = auth.GetDatabase("shop");
            var collection = database.GetCollection<avtorizatia>("auth");
            return collection.Find(x => true).ToList();
        }
        public static List<regnov> regnovs()
        {
            var auth = new MongoClient("mongodb://localhost");
            var database = auth.GetDatabase("shop");
            var collection = database.GetCollection<regnov>("regnov1");

           return collection.Find(x => true).ToList() ; 
        }
    }
}
