using MongoDB.Driver;
using MongoDB.Bson;

using System;
using System.Collections.Generic;

namespace ExemploMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string conexaoMongo = "mongodb://localhost/";
                MongoClient client = new MongoClient(conexaoMongo);
                var dataBase = client.GetDatabase("TesteMongoDB");

                //GetPessoas(client, dataBase);
                //InsertTeste(dataBase);
                //GetTeste(dataBase);
                //GetTeste2(dataBase);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private static void GetTeste2(IMongoDatabase dataBase)
        {
            var teste = dataBase.GetCollection<Teste>("Teste");
            var result = teste.Find(qr => qr.Namorada != null).ToList();
        }

        private static void GetTeste(IMongoDatabase dataBase)
        {
            var teste = dataBase.GetCollection<BsonDocument>("Teste");

            var result = teste.Find(new BsonDocument()).ToList();
        }

        private static void InsertTeste(IMongoDatabase dataBase)
        {
            var teste = dataBase.GetCollection<BsonDocument>("Teste");

            //1º forma de inserção
            //var documento = new BsonDocument() {
            //        {"Nome","Fulano"},
            //        {"Cidade", "são Paulo"}
            //    };


            //2º Forma de inserção
            var documento = new BsonDocument() {
                    {"Nome","Felipe"},
                    {"Namorada", new BsonDocument() {
                        { "Nome", "Joice Marques"},
                        { "Idade", 18}
                    }
                   }                    
                };

            teste.InsertOne(documento);
        }        

        private static List<Pessoa> GetPessoas(MongoClient clientm, IMongoDatabase dataBase)
        {
            var colecao = dataBase.GetCollection<Pessoa>(typeof(Pessoa).Name);
            var r = colecao.Find(qr => qr.Idade == 21).ToList();
            return r;
        }
    }
}
