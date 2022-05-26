using CRUDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace CRUDWebAPI.Controllers
{
    public class StudentsController : ApiController
    {
        CollegeEntities OE = new CollegeEntities();
        public IQueryable<Student> Get()
        {
            return OE.Students;
        }
    }
}