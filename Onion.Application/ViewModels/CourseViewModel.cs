using Onion.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
