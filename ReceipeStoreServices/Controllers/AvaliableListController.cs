using System;
using System.Collections.Generic;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using MongoDB.Bson;
using Newtonsoft.Json;
using ReceipeStoreServices.DatabaseEntities;
using ReceipeStoreServices.Models;
using ReceipeStoreServices.HelperClasses;
using DbReceipeType = ReceipeStoreServices.DatabaseEntities.DbReceipeType;

namespace ReceipeStoreServices.Controllers
{
    public class AvaliableListController : ApiController
    {
        // GET: api/AvaliableList
        public HttpResponseMessage Get()
        {
            
            List<DbReceipeType> AvaliableList = new List<DbReceipeType>();
            
            using (MongoRepository _repository = new MongoRepository())
            {
                AvaliableList = _repository.RetrieveCollection();

            }
              
            List<ReceipeType> responseList = new List<ReceipeType>();

            AvaliableList.ForEach(x => responseList.Add(new ReceipeType(x.ReciepeID, x.Name )));
                
            HttpResponseMessage returnResponse = Request.CreateResponse(HttpStatusCode.OK, responseList);
            
           
            return returnResponse;
        }

        //// GET: api/AvaliableList/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/AvaliableList
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/AvaliableList/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/AvaliableList/5
        //public void Delete(int id)
        //{
        //}
    }
}
