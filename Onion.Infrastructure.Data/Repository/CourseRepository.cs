using Onion.Domain.Interfaces;
using Onion.Domain.Models;
using Onion.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _ctx;
        public CourseRepository(UniversityDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
