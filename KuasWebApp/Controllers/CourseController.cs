using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KuasWebApp.Controllers
{
    public class CourseController : ApiController
    {
        public ICourseService CourseService { get; set; }

        [HttpPost]
        public Course AddCourse(Course course)
        {
            CheckCourseIsNotNullThrowException(course);

            try
            {
                CourseService.AddCourse(course);
                return CourseService.GetEmployeeByName(course.CourseName);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }



        [HttpGet]
        [ActionName("byName")]
        public Course GetEmployeeByName(string Name)
        {
            var course = CourseService.GetCourseByName(Name);

            if course == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return coursee;
        }

        private void CheckCourseIsNotNullThrowException(Course course)
        {
            Course dbcourse = CourseService.GetEmployeeByName(course.CourseID);

            if (dbcourse != null)
            {
                throw new HttpResponseException(HttpStatusCode.Conflict);
            } 
        }
    }
}
