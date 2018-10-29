using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public Course GetCourse(string name)
        {
            return courses.Find(x => x.Name == name);
        }

        public double GetTotalValue()
        {
            double allCourse = 0;
            foreach (Course c in courses)
            {
                allCourse += c.DurationInMinutes;
            }

            return allCourse;
        }
    }
}
