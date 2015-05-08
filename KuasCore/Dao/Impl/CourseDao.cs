using KuasCore.Dao.Base;
using KuasCore.Models;
using Spring.Data.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    class CourseDao : GenericDao<Course>, ICourseDao
    {

        public void AddCourse(Course course)
        {
            string command = @"INSERT INTO Course (CourseID, CourseName, CourseDescription) VALUES (@ID, @Name, @Description);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("ID", DbType.String).Value = course.CourseID;
            parameters.Add("Name", DbType.String).Value = course.CourseName;
            parameters.Add("Description", DbType.String).Value = course.CourseDescription;

            ExecuteNonQuery(command, parameters);
        }

       

        public Course GetCourseByName(String Name)
        {
            string command = @"SELECT * FROM Course WHERE CourseName = @Name";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Name", DbType.String).Value = Name;

            IList<Course> courses = ExecuteQueryWithRowMapper(command, parameters);
            if (courses.Count > 0)
            {
                return courses[0];
            }

            return null;
        }
    }
}
