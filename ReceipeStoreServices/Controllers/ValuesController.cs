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
using ReceipeStore;
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
        public HttpResponseMessage  Get()
        {

            ReadInput input = new ReadInput(); 
            
            List<Receipe> reclist = new List<Receipe>();
            reclist =
                input.ReadfromInput(@"C:\Users\mudunuride01\Documents\GitHub\ReceipesProd\ReciepesProd\InputFile.xlsx");
            if (reclist == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, reclist);

            //HttpResponseMessage finalResult =  new HttpResponseMessage (HttpStatusCode.OK)
            //{
            //    Content =  new ObjectContent(Type List<Receipe>,reclist,new JsonMediaTypeFormatter());
            //}


            //HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK)
            //{
            //     Content =  new ObjectContent(List<Receipe>, input.ReadfromInput(@"C:\Users\mudunuride01\Documents\GitHub\ReceipesProd\ReciepesProd\InputFile.xlsx"));

            //                Content =
            //                    new StringContent(
            //                        ("{\"reciepes\":[ {\"Name\":\"Snacks\",\"City\":\"Berlin\",\"Country\":\"Germany\"}, {\"Name\":\"Curries\",\"City\":\"México D.F.\",\"Country\":\"Mexico\"}]}")
            //            };
            //            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //            return result;
                    }

              
            }
        }