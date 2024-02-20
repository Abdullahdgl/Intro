using Kodlama.ioProject.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject.DataAccess.Abstract
{
    public interface IBaseDal<T> where T : class,IEntity,new ()
    {
     
   
        List<T> GetAll();

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
