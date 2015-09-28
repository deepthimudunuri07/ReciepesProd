using System;
using System.Collections.Generic;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReceipeStoreServices.Models;

namespace ReceipeStoreServices.Controllers
{
    public class AvaliableListController : ApiController
    {
        // GET: api/AvaliableList
        public HttpResponseMessage Get()
        {
            List<ReceipeType> AvaliableList = new List<ReceipeType>();
            
            string[] myarray = new string[] {"Curries", "Rice", "Snacks", "Deserts"};
            for (int i = 0; i < myarray.Length; i++)
            {
                AvaliableList.Add(new ReceipeType(i+1,myarray[i]));
            }

            return  Request.CreateResponse(HttpStatusCode.OK, AvaliableList);
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
