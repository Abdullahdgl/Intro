using Core.Utilities.Results;
using Kodlama.ioProject2.Core.Utilities.Result;
using Kodlama.ioProject2.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject2.Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        Course GetById(int courseId);
        
        IResult Add(Course course);
        IResult Update(Course course);

        IResult Delete(Course course);
        
    }
}
