using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultPattern;

public abstract class Result : Result<Object>
{
    public override object Data => null;
}


public abstract class Result<T>
{
    public abstract ResultTypes ResultType { get; }
    public abstract IEnumerable<string> Errors { get; }
    public abstract T Data { get; }
}

public class OkResult<T> : Result<T>
{
    private readonly T _data;
    public OkResult(T data)
    {
        _data = data;
    }
    public override ResultTypes ResultType => ResultTypes.Ok;
    public override IEnumerable<string> Errors => Array.Empty<string>();
    public override T Data => _data;

}

public class NoContentResult : Result
{
    public NoContentResult()
    {

    }
    public override ResultTypes ResultType => ResultTypes.NoContent;
    public override IEnumerable<string> Errors => Array.Empty<string>();
}

public class NotFoundResult<T> : Result<T>
{
    private IEnumerable<string> _errors;
    public NotFoundResult(params string[] errors)
    {
        _errors = errors;
    }

    public override ResultTypes ResultType => ResultTypes.NotFound;
    public override IEnumerable<string> Errors => _errors;
    public override T Data => default;
}

public enum ResultTypes
{
    Ok,
    NoContent,
    Invalid,
    NotFound,
    Unexpected,
}
