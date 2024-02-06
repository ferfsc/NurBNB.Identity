using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurBnb.Identity.Application.Dto;

public class Result
{
    public bool Success { get; set; }
    public string? Message { get; set; }

    public string Name { get;set; }

    public Result(bool success, string message)
    {
        Success = success;
        Message = message;
    }
    public Result(bool success, string message, string name)
    {
	   Success = success;
	   Message = message;
	   Name = name;
    }
    public Result(bool success)
    {
        Success = success;
    }
    private Result()
    {
    }
}

public class Result<T> : Result
{
    public T? Value { get; set; }

    public Result(bool success, string message) : base(success, message)
    {
        Success = success;
        Message = message;
    }
    public Result(bool success, string message, string name) : base(success, message, name)
    {
	   Success = success;
	   Message = message;
	   Name = name;
    }
    public Result(bool success) : base(success)
    {
        Success = success;
    }

    public Result(T value, bool success, string message) : base(success, message)
    {
        Value = value;
    }
    public Result(T value, bool success, string message, string name) : base(success, message, name)
    {
	   Value = value;
    }
    public Result(T value, bool success) : base(success)
    {
        Value = value;
    }
}
