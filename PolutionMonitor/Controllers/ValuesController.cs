using PolutionMonitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Mvc;

namespace PolutionMonitor.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ApplicationDbContext _context = null;
        public ValuesController(ApplicationDbContext context)
        {
            _context = context;
            
            
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/values/5
        public JsonResult Get(int id)
        {
            return new JsonResult { Data = new { name = "ahmad", data = 5 }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
