using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MongoDB.Bson;
using MongoDB.Driver;
using ReceipeStore;
using ReceipeStoreServices.DatabaseEntities;
using ReceipeStoreServices.Models;

namespace ReceipeStoreServices.Controllers
{
    public class ReciepeController : ApiController
    {
       

        // GET: api/Reciepe/5
        public HttpResponseMessage Get(int ReciepeiD)
        {
            //ReadInput input = new ReadInput();

            List<DbReceipe> reclist = new List<DbReceipe>();

            using (MongoRepository _repository = new MongoRepository())
            {
                var filter = Builders<DbReceipe>.Filter.Eq("ReciepeID", ReciepeiD);
                reclist = _repository.RetrieveCollection<DbReceipe>("Reciepe",filter);
            }

            List<Receipe> responseList = new List<Receipe>();
            
        
            reclist.ForEach(x => responseList.Add(new Receipe(x.ReciepeID,x.Name, x.Ingredients, x.Instructions, x.CookingTime, x.PreparationTime, x.IsHealthy, x.IsDiabetic, x.ReciepeType, x.CuisineType,x.ImageUrl)));
            HttpResponseMessage returnResponse = Request.CreateResponse(HttpStatusCode.OK, responseList);


            return returnResponse;
           
        }

        // POST: api/Reciepe
        public void Post([FromBody]Receipe value)
        {
            using (MongoRepository _repository = new MongoRepository())
            {
                DbReceipe document = new DbReceipe(value.ReceipeTypeID,value.Name,value.Ingredients,value.Instructions,value.CookingTime,value.PreparationTime,value.IsHealthy,value.IsDiabetic,false,value.ImageUrl);
                _repository.InsertCollection<DbReceipe>("Reciepe", document);
            }
        }

        // PUT: api/Reciepe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Reciepe/5
        public void Delete(int id)
        {
        }
    }
}
