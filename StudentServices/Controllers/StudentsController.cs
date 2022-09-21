using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentDataAccess;

namespace StudentServices.Controllers
{
    public class StudentsController : ApiController
    {
        // GET: api/Students
        public IEnumerable<Students> Get()
        {
            using (StudentDetailsEntities entities = new StudentDetailsEntities())
            {
                return entities.Students.ToList();
            }
        }
        // GET: api/Students/5
        public Students Get(int id)
        {
            using (StudentDetailsEntities entities = new StudentDetailsEntities())
            {
                return entities.Students.FirstOrDefault(e => e.id == id);
            }
        }

        // POST: api/Students
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Students/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Students/5
        public void Delete(int id)
        {
        }
    }
}
