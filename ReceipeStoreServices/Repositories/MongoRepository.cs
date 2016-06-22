using System;
using System.Collections.Generic;
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
       
        //public List<DbReceipeType> RetrieveCollection()
        //{
        //    OpenConnection();
        //    var filter = new BsonDocument();
        //    var collection = _Database.GetCollection<DbReceipeType>("ReciepeType");
        //    var results =  collection.Find(filter).ToList();
        //   return results;
        
        //}

        public List<T> RetrieveCollection<T>(string collectionName, FilterDefinition<T> filters)
        {
            OpenConnection();
            var collection = _Database.GetCollection<T>(collectionName);
            var results = collection.Find(filters).ToList();
            return results;
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