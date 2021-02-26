using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T data, bool success, string message) : base(success, message)
        {

        }

        public DataResult(T data, bool success) : base(success)
        {

        }
    }
}
