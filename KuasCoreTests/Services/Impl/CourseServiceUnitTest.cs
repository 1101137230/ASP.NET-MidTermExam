using KuasCore.Models;
using KuasCore.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCoreTests.Services.Impl
{
    [TestClass]
    public class CourseServiceUnitTest : AbstractDependencyInjectionSpringContextTests
    {
        public ICourseService CourseService { get; set; }
        [TestMethod]
        public void TestCourseDao_AddCourse()
        {
            Course course = new Course();
            course.CourseID = "UnitTests";
            course.CourseName = "單元測試";
            course.CourseDescription = "tryyyy";
            CourseService.AddCourse(course);

            Course dbcourse = CourseService.GetCourseByName(course.CourseName);
            Assert.IsNotNull(dbcourse);
            Assert.AreEqual(course.CourseName, dbcourse.CourseName);

            Console.WriteLine("課程編號為 = " + dbcourse.CourseID);
            Console.WriteLine("課程名稱為 = " + dbcourse.CourseName);
            Console.WriteLine("課程描述為 = " + dbcourse.CourseDescription);
        }
        [TestMethod]
        public void TestCourseDao_GetCourseeByID()
        {
            Course course = CourseService.GetCourseByName("體育課");
            Assert.IsNotNull(course);
            Console.WriteLine("課程編號為 = " + course.CourseID);
            Console.WriteLine("課程名稱為 = " + course.CourseName);
            Console.WriteLine("課程描述為 = " + course.CourseDescription);
        }
    }
}
