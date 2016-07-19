using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploMongoDB
{
    public class Teste
    {
        public ObjectId _id { get; set; }
        public string Nome { get; set; }
        public Namorada Namorada { get; set; }
    }

    public class Namorada
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
