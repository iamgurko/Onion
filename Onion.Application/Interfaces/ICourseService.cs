using Onion.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
