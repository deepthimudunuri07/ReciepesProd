using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Web.Mvc;


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
        public HttpResponseMessage Get()
        {
            XDocument InputXml = XDocument.Load(@"C:\InputFile.xml");
            var Result = InputXml.Descendants("ReceipeType");
            return Request.CreateResponse(HttpStatusCode.OK, Result);
            //return Json(Result, JsonRequestBehavior.AllowGet);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
