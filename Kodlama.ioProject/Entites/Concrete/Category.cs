using Kodlama.ioProject.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject.Entites.Concrete
{
    public class Category :IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
