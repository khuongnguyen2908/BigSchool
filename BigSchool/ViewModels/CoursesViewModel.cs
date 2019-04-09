using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool.Models;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Attendance> attandence { get; set; }
       
        public IEnumerable<Following> following { get; set; }
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}