using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;

namespace Updating_Child_Task_With_Story_Details_WebAPI.Controllers.API
{
    public class UpdateChildTaskVPController : ApiController
    {
        // GET: api/UpdateChildTaskVP
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UpdateChildTaskVP/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UpdateChildTaskVP
        public OkResult Post([FromBody]string value)
        {
            return Ok();
        }

        // PUT: api/UpdateChildTaskVP/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UpdateChildTaskVP/5
        public void Delete(int id)
        {
        }
    }
}
