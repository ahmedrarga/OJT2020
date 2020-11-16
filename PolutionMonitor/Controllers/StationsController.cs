using PolutionMonitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace PolutionMonitor.Controllers
{
    public class StationsController : ApiController
    {
        private readonly ApplicationDbContext _context;
        public StationsController(ApplicationDbContext context)
        {
            _context = context;
        }
        /*
        // GET: api/Stations
        public JsonResult Get()
        {
            var data = _context.Detectors.ToList();
            return new JsonResult { Data = new { data = data }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        // GET: api/Stations/5
        public JsonResult Get(int id)
        {
            var succ = false;
            var item = _context.Detectors.FirstOrDefault(x => x.DetectorID == id);
            if (item != null)
            {
                succ = true;
            }
            return new JsonResult { Data = new { success = succ, data = item }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // POST: api/Stations
        public JsonResult Post([FromBody]Detector value)
        {
            var succ = false;
            try
            {
                _context.Entry(value).State = System.Data.Entity.EntityState.Added;
                _context.SaveChanges();
                succ = true;
            }catch (Exception ex)
            {

            }
            return new JsonResult { Data = new { success = succ }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // PUT: api/Stations/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Stations/5
        public JsonResult Delete(int id)
        {
            var succ = false;
            try
            {
                _context.Detectors.RemoveRange(_context.Detectors.Where(x => x.DetectorID == id));
                _context.SaveChanges();
                succ = true;
            }catch (Exception ex)
            {

            }
            return new JsonResult { Data = new { success = succ }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        */
    }
}
