using Kodlama.ioProject2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject2.Entites.DTOs
{
    public class CourseDetailDto :IDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CoursePrice { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }

    }
}
