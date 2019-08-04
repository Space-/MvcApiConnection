using System;
using System.Web;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using MvcApiConnection.Models;

namespace MvcApiConnection.Controllers
{
    public class MsgController : ApiController
    {
        // GET: Msg
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: Msg/5
        public string Get(int id)
        {
            return $"You Get id: {id}";
        }

        // POST: Msg
        public string Post([FromBody]Person person)
        {
            return ModelState.IsValid && person.IsAdmin() ? "You can access!" : "Access denied.";
        }

        // PUT: Msg/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: Msg/5
        public void Delete(int id)
        {
        }
    }
}