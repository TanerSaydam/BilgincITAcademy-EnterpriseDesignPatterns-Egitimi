namespace CleanArchitecture.Domain.Abstractions;
public sealed class Result<T>
{
    private Result()
    {

    }
    public Result(T? data)
    {
        Data = data;
    }

    public T? Data { get; set; }
    public string? ErrorMessage { get; set; }
    public bool IsSuccessful { get; set; } = true;

    public static implicit operator Result<T>(T data)
    {
        return new(data);
    }

    public static Result<T> Failure(string message)
    {
        Result<T> result = new();
        result.ErrorMessage = message;
        result.IsSuccessful = false;

        return result;
    }
}
