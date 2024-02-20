﻿using Kodlama.ioProject.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject.Entites.Concrete
{
    public class Instructor :IEntity
    {
        public int InstructorId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> courses { get; set; }
    }
}
