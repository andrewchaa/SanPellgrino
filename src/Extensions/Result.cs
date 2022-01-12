using System;

namespace SanPellgrino
{
    public class Result
    {
        public Exception Error { get; set; }
        public bool Success => Error == null;

        public Result() { }
        public Result(Exception error)
        {
            Error = error;
        }
    }

    public class Result<T>: Result
    {
        public T Data { get; set; }

        public Result() { }

        public Result(T data)
        {
            Data = data;
        }
        
        public Result(Exception error) : base(error)
        {}
    }
