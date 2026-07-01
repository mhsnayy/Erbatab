using System;
using System.Collections.Generic;
using System.Text;

namespace Erbatab.Shared.ResultPattern
{
    public class Result
    {
        public bool IsSuccess { get; }
        public string Message { get; }

        protected Result(bool isSuccess, string message = null)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public static Result Success()
        {
            return new Result(true);
        }
        public static Result Success(string message)
        {
            return new Result(true, message);
        }

        public static Result Failure(string message)
        {
            return new Result(false, message);
        }
    }
}
