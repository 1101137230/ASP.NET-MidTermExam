using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Services.Impl
{
    public class CourseService :ICourseService
    {
        public ICourseService CourseDao { get; set; }
        public void AddCourse(Course course)
        {
            CourseDao.AddCourse(course);
        }

        public Course GetEmployeeByName(string Name)
        {
            return CourseDao.GetEmployeeByName(Name);
        }
    }
}
