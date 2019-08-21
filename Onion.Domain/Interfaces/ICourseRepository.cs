﻿using Onion.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
