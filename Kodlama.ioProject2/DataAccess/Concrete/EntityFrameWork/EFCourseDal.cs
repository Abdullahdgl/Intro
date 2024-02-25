using Kodlama.ioProject2.Core.DataAccess.EntityFrameWork;
using Kodlama.ioProject2.DataAccess.Abstract;
using Kodlama.ioProject2.Entites.Concrete;
using Kodlama.ioProject2.Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject2.DataAccess.Concrete.EntityFrameWork
{
    public class EFCourseDal : EfEntityRepositoryBase<Course, KodlamaContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (KodlamaContext context= new KodlamaContext())
            {
                var result = from c in context.courses
                             select new CourseDetailDto
                             {
                                 CourseId = c.CourseId,
                                 CourseName = c.CourseName,
                                 CategoryId = c.CategoryId,
                                 CoursePrice = c.CoursePrice,
                             };
                return result.ToList();

            }
        }
    }
}
