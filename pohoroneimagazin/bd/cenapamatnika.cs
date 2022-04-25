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
    internal class cenapamatnika
    {
        public cenapamatnika(decimal cena)
        {
            this.cena = cena;
        }

        public ObjectId Id { get; set; }
        public decimal cena { get; set; }


        
    }

     
}
