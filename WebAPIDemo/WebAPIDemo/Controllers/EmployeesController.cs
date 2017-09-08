using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace WebAPIDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<tblEmployee> Get()
        {
            using (SampleEntities entities = new SampleEntities())
            {
                return entities.tblEmployees.ToList();
            }
        }

        public tblEmployee Get(int id)
        {
            using (SampleEntities entities = new SampleEntities())
            {
                return entities.tblEmployees.FirstOrDefault(e=>e.Id == id);
            }
        }
    }
}
