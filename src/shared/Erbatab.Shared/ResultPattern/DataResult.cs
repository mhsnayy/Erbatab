using System;
using System.Collections.Generic;
using System.Text;

namespace Erbatab.Shared.ResultPattern
{
    public class DataResult<T> : Result
    {
        public T Data { get; }

        private DataResult(T data, bool isSuccess, string message = null)
            : base(isSuccess, message)
        {
            Data = data;
        }

        public static DataResult<T> Success(T data, string message)
        {
            return new DataResult<T>(data, true, message);
        }
        public static DataResult<T> Success(T data)
        {
            return new DataResult<T>(data, true);
        }

        public new static DataResult<T> Failure(string message)
        {
            return new DataResult<T>(default, false, message);
        }
    }
}
