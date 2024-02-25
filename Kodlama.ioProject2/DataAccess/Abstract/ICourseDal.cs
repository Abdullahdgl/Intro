using Kodlama.ioProject2.Core.DataAccess;
using Kodlama.ioProject2.Entites.Concrete;
using Kodlama.ioProject2.Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject2.DataAccess.Abstract
{
    public interface ICourseDal:IEntityRepository<Course>
    {
        List<CourseDetailDto> GetCourseDetails();

    }
}
