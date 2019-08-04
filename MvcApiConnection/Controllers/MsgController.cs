using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using MvcApiConnection.Models.Person;
using System.Web.Http;
using MvcApiConnection.Models;

namespace MvcApiConnection.Controllers
{
    public class MsgController : ApiController
    {
        // GET: api/Msg
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Msg/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Msg
        public void Post([FromBody]string value)
        {
            var p = new Person();
            p.Name = "Bruce";
            p.Height = 172;
        }

        // PUT: api/Msg/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Msg/5
        public void Delete(int id)
        {
        }
    }
}