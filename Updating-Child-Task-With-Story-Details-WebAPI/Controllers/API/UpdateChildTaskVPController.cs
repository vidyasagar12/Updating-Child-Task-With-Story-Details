using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using Updating_Child_Task_With_Story_Details_WebAPI.Models;

namespace Updating_Child_Task_With_Story_Details_WebAPI.Controllers.API
{
    [RoutePrefix("api")]
    public class UpdateChildTaskVPController : ApiController
    {
        static ModelProps props;
        // GET: api/UpdateChildTaskVP
        [HttpGet]
        [Route("getItems")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //UpdateChildTaskVP
        // GET: api/UpdateChildTaskVP/5
        [HttpGet]
        [Route("getItemsId")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        [Route("postTaskDetails")]
        // POST: api/UpdateChildTaskVP
        public OkResult Post()
        {
            //var requestBody=Request.Content.ReadAsStringAsync().Result;
         
            var requestBody = System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath("~/JSON/TaskData"));
            Task task = JsonConvert.DeserializeObject<Task>(requestBody);
         
            props = new ModelProps()
            {
                parentId = 1,
                projectId = "",
                PAT = ""
            };
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

        public Task GetParentStory(ModelProps props)
        {
            return null;
        }
    }
}
