﻿using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        public string Place { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        [FutureDate(ErrorMessage = "Định dạng ngày sai")]
        public string Date { get; set; }

        [ValidTime(ErrorMessage = "Định dạng giờ sai")]
        [Required(ErrorMessage = "Not be empty")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; set; }
        public string Action { get { return (Id != 0) ? "Update" : "Create"; } }
        public DateTime GetDatetime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}