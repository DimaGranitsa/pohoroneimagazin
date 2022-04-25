using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
using MongoDB.Bson.Serialization.Attributes;

namespace pohoroneimagazin.bd
{
    internal class regnov
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _login;
        public ObjectId _password;

        public regnov(ObjectId login, ObjectId password)
        {
            _login = login;
            _password = password;
        }
        public string login { get; set; }
        public string password { get; set; }
    }
}
