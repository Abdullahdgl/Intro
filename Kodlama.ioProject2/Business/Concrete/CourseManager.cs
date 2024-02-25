using Core.Utilities.Results;
using Kodlama.ioProject2.Business.Abstract;
using Kodlama.ioProject2.Business.Contants;
using Kodlama.ioProject2.Core.Utilities.Result;
using Kodlama.ioProject2.DataAccess.Abstract;
using Kodlama.ioProject2.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject2.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            if (course.CourseName.Length >= 2 && course.CoursePrice>0 )
            {
                return new ErrorResult(Messages.CourseNameInvalid);

            }
            _courseDal.Add(course);
            return new SuccessResult(Messages.CourseAdded);

        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CourseDeleted);
        }

        public IDataResult<List<Course>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Course GetById(int courseId)
        {
            return _courseDal.Get(crs=> crs.CourseId == courseId);
        }

        public IResult Update(Course course)
        {
           _courseDal.Update(course);
            return new SuccessResult(Messages.CourseUpdated);   
        }
    }
}
