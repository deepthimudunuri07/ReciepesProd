using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using ReceipeStore;
using ReceipeStoreServices.DatabaseEntities;
using ReceipeStoreServices.Models;


namespace ReceipeStoreServices.Controllers
{
    public class ValuesController : ApiController
    {
        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        //public HttpResponseMessage  Get()
        //{

        //    ReadInput input = new ReadInput(); 
            
        //    List<Receipe> reclist = new List<Receipe>();
        //    reclist =
        //        input.ReadfromInput(@"C:\Users\mudunuride01\Documents\GitHub\ReceipesProd\ReciepesProd\InputFile.xlsx");
        //    if (reclist == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, reclist);

           
        //            }


        public HttpResponseMessage Get(int selected)
        {


            List<DbReceipe> AvaliableList = new List<DbReceipe>();

            using (MongoRepository _repository = new MongoRepository())
            {
                var filter = Builders<DbReceipe>.Filter.Eq("ReciepeType", selected);
                AvaliableList = _repository.RetrieveCollection<DbReceipe>("Reciepe", filter);
            }

            List<Receipe> responseList = new List<Receipe>();
            AvaliableList.ForEach(x => responseList.Add(new Receipe(x.ReciepeID,x.Name, x.Ingredients, x.Instructions, x.CookingTime, x.PreparationTime, x.IsHealthy, x.IsDiabetic, x.ReciepeType, x.CuisineType,x.ImageUrl)));
            HttpResponseMessage returnResponse = Request.CreateResponse(HttpStatusCode.OK, responseList);


            return returnResponse;
            //ReadInput input = new ReadInput();

            //List<Receipe> reclist = new List<Receipe>();
            //reclist =
            //    input.ReadfromInput(@"C:\Users\mudunuride01\Documents\GitHub\ReceipesProd\ReciepesProd\InputFile.xlsx");
            //if (reclist == null)
            //{
            //    throw new HttpResponseException(HttpStatusCode.NotFound);
            //}

            // var reclist1 = from receipe in reclist where receipe.ReceipeTypeID == selected select receipe;

           //return Request.CreateResponse(HttpStatusCode.OK, reclist1);


        }

        private int GetReciepeType()
        {
            return 1;
        }
              
            }
        }