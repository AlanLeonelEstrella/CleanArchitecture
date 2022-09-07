using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Moldels;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;
        public CourseRepository(UniversityDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
