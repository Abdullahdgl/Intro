﻿using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concrete;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            //business rules
           
            return _courseDal.GetAll();

        }
    }
}
