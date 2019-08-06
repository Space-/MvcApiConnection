using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using MvcApiConnection.Models;

namespace MvcApiConnection.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "accept,content-type,origin", methods: "Get,Post")]
    public class MsgController : ApiController
    {
        // GET: Msg
        public IEnumerable<string> Get()
        {
            return new[] { "GetResponseValue1", "GetResponseValue2" };
        }

        // GET: Msg/1
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