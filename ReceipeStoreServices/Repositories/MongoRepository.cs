using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc.Html;
using Microsoft.Ajax.Utilities;
using Microsoft.SqlServer.Server;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core.Clusters.ServerSelectors;
using ReceipeStoreServices.DatabaseEntities;
using ReceipeStoreServices.Models;

namespace ReceipeStoreServices
{
    public class MongoRepository:IDisposable
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _Database;
        
        
        public void OpenConnection()
        {

            string connection = ConfigurationManager.AppSettings["ConnectionStr"];
            _client = new MongoClient();
            _Database = _client.GetDatabase("ReciepeHub");
        }
       
       
        public List<T> RetrieveCollection<T>(string collectionName, FilterDefinition<T> filters)
        {
            OpenConnection();
            var collection = _Database.GetCollection<T>(collectionName);
            var results = collection.Find(filters).ToList();
            return results;
        }

        //public DbReceipe RetrieveLastInserted()
        //{
        //    var collection = _Database.GetCollection<DbReceipe>("Reciepe");
        //    var builder = Builders<DbReceipe>.Sort;
        //    var sort = builder.Descending("ReciepeID");
        //    var result = collection.Find(new BsonDocumentFilterDefinition<DbReceipe>(new BsonDocument()));
        //  List<DbReceipe> rec =  result.Sort(sort).Limit(1).ToList();
        //    return rec.Find(x=> x.ReciepeID!= null);
        //}

        public T RetrieveLastInserted<T>(string collectionName, string sortID)
        {
            var collection = _Database.GetCollection<T>(collectionName);
            var builder = Builders<T>.Sort;
            var sort = builder.Descending(sortID);
            var result = collection.Find(new BsonDocumentFilterDefinition<T>(new BsonDocument()));
            List<T> rec = result.Sort(sort).Limit(1).ToList();
            return rec.FirstOrDefault();
        }

        public void InsertCollection<T>(string collectionName, T document)
        {
            var collection = _Database.GetCollection<T>(collectionName);
           
            collection.InsertOne(document);
        }

        public void Dispose()
        {
            
        }
    }
}