﻿using Kodlama.ioProject2.Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message): base(success,message)
        {
            Data = data;
            
        }
        public DataResult(T datai, bool success):base (success)
        {
            Data = Data;       
        }
        public T Data { get; }
    }
}
