using BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool.Controllers.Api
{
    public class DeleteController : ApiController
    {
        public ApplicationDbContext _dbContext { get; set; }

        public DeleteController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbContext.Attendances.Single(c => c.CourseId == id && c.AttendeeId == userId);

            _dbContext.Attendances.Remove(course);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
