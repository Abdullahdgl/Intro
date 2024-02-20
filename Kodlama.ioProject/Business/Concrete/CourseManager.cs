using Kodlama.ioProject.Business.Abstract;
using Kodlama.ioProject.DataAccess.Abstract;
using Kodlama.ioProject.Entites.Abstract;
using Kodlama.ioProject.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject.Business.Concrete
{
    public class CourseManager : ICourseService
    {
       private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }



        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);

        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();

        }
    

  
        public void Update(Course course)
        {

             _courseDal.Update(course);


        }
    }
}
