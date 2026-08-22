using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFlow.Domain.Common.ResutlPatterns
{
    public interface IResult
    {
        bool IsSuccess { get; }
        string? Error { get; }
    }

    public class Result : IResult
    {
        public bool IsSuccess { get; init; }

        public string? Error { get; init; }

        public static Result Success()
            => new() { IsSuccess = true };

        public static Result Failure(string error)
            => new() { IsSuccess = false, Error = error };
    }

    public class Result<T> : Result
    {
        public T? Value { get; init; }

        public static Result<T> Success(T value)
            => new()
            {
                IsSuccess = true,
                Value = value
            };

        public new static Result<T> Failure(string error)
            => new()
            {
                IsSuccess = false,
                Error = error
            };
    }

}
