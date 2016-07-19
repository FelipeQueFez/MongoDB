using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploMongoDB
{
    public class Pessoa
    {
        public ObjectId _id { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }
    }
}
