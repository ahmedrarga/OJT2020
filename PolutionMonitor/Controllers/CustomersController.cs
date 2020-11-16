using Newtonsoft.Json.Linq;
using PolutionMonitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace PolutionMonitor.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Customers
        //Get all customers
        public JsonResult Get()
        {
            var customers = _context.Users.ToList();
            return new JsonResult { Data = new { customers }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        // GET: api/Customers/5
        //Get customer by id
        public JsonResult Get(int id)
        {
            var obj = _context.Users.FirstOrDefault(x => x.ID == id);
            if (obj != null)
            {  
                return new JsonResult { Data = new { success = true, data = obj }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
            return new JsonResult { Data = new {success = false}, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            

        }

        // POST: api/Customers
        //Add customer
        public JsonResult Post([FromBody]User obj)
        {
            var succ = false;
            try
            {
                _context.Entry(obj).State = System.Data.Entity.EntityState.Added;
                _context.SaveChanges();
                succ = true;
            }catch(Exception e)
            {

            }
            return new JsonResult { Data = new { success = succ }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            
        }

        // PUT: api/Customers/5
        //modify customer
        public JsonResult Put(int id, [FromBody]User obj)
        {
            var succ = false;
            try
            {
                var toEdit = _context.Users.FirstOrDefault(x => x.ID == id);
                if (toEdit != null)
                {
                    toEdit.username = obj.username;
                    toEdit.firstName = obj.firstName;
                    toEdit.lastName = obj.lastName;
                    toEdit.organizationID = obj.organizationID;
                    toEdit.password = obj.password;
                    toEdit.email = obj.email;
                    toEdit.phoneNumber = obj.phoneNumber;

                    _context.Entry(toEdit).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    succ = true;
                }

            } catch (Exception e)
            {

            }
            return new JsonResult { Data = new { success = succ, id = id}, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        // DELETE: api/Customers/5
        //delete customer
        public JsonResult Delete(int id)
        {
            var succ = false;
            try
            {
                _context.Users.RemoveRange(_context.Users.Where(x => x.ID == id));
                _context.SaveChanges();
                succ = true;
            } catch(Exception e)
            {

            }
            return new JsonResult { Data = new { success = succ }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
       
    }
}
