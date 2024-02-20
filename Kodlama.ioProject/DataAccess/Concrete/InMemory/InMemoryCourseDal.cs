using Kodlama.ioProject.DataAccess.Abstract;
using Kodlama.ioProject.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject.DataAccess.Concrete.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        List<Course> _courses;
        public InMemoryCourseDal()
        {
            _courses = new List<Course>
            {
                new Course{CourseId=1,CategoryId=1 , CourseName="C#", CoursePrice=1500, Description="Level 2"},
                 new Course{CourseId=2,CategoryId=1 , CourseName="Java", CoursePrice=50000, Description="Level 1"},
                  new Course{CourseId=3,CategoryId=2 , CourseName="python", CoursePrice=150000, Description="Level 3"},
                   new Course{CourseId=1,CategoryId=2 , CourseName="delphi", CoursePrice=15000,Description="Level 1"},
                    new Course{CourseId=1,CategoryId=2 , CourseName="qbasic", CoursePrice=8500, Description="Level 1"}
            };

        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseDeleted = _courses.SingleOrDefault(crs=>crs.CourseId==course.CourseId);
            _courses.Remove(courseDeleted);

        }

      
        public List<Course> GetAll()
        {
            Console.WriteLine("GetAll Çalıştı");
            return _courses;

        }
       

        public List<Course> GetByCategory(int categoryId)

        {
            _courses.Where(crs=>crs.CategoryId==categoryId).ToList();
            return _courses;
        }
        public void Update(Course course)
        {
        
            Course updateCourse = _courses.FirstOrDefault(crs=>crs.CourseId == course.CourseId);
            updateCourse.CourseId = course.CourseId;
            updateCourse.Description = course.Description;
            updateCourse.CoursePrice = course.CoursePrice;
            updateCourse.CategoryId = course.CategoryId;
            updateCourse.CourseName = course.CourseName;


        }
    }
}
