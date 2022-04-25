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
    internal class avtorizatia
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public avtorizatia(ObjectId id, string login, string password)
        {
            _id = id;
            this.login = login;
            this.password = password;
        }

        public string login { get; set; }
        public string password { get; set; }

    }
}
