using KuasCore.Dao;
using KuasCore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCoreTests.Dao
{
    [TestClass]
    public class CourseDaoUnitTest : AbstractDependencyInjectionSpringContextTests
    {
        #region 單元測試 Spring 必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    // assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }
        #endregion

        public ICourseDao CourseDao { get; set; }

        [TestMethod]
        public void TestCourseDao_AddCourse()
        {
            Course course = new Course();
            course.CourseID = "UnitTests";
            course.CourseName = "單元測試";
            course.CourseDescription = "tryyyy";
            CourseDao.AddCourse(course);

            Course dbcourse = CourseDao.GetCourseByName(course.CourseName);
            Assert.IsNotNull(dbcourse);
            Assert.AreEqual(course.CourseName, dbcourse.CourseName);

            Console.WriteLine("課程編號為 = " + dbcourse.CourseID);
            Console.WriteLine("課程名稱為 = " + dbcourse.CourseName);
            Console.WriteLine("課程描述為 = " + dbcourse.CourseDescription);
        }
        [TestMethod]
        public void TestCourseDao_GetCourseeByID()
        {
            Course course = CourseDao.GetCourseByName("體育課");
            Assert.IsNotNull(course);
            Console.WriteLine("課程編號為 = " + course.CourseID);
            Console.WriteLine("課程名稱為 = " + course.CourseName);
            Console.WriteLine("課程描述為 = " + course.CourseDescription);
        }

    }
    

    
}
