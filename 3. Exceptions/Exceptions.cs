using System;

public class InvalidRangeException<T> : ApplicationException
{
    public T Value { get; private set; }

    public T Min { get; private set; }

    public T Max { get; private set; }

    public InvalidRangeException()
    {
    }

    public InvalidRangeException(string msg, Exception innerException = null)
        : this(msg, default(T), innerException)
    {
    }

    public InvalidRangeException(string msg, T value, Exception innerException = null)
        : this(msg, value, default(T), default(T), innerException)
    {
    }

    public InvalidRangeException(string msg, T value, T min, T max, Exception innerException = null)
        : base(msg, innerException)
    {
        Value = value;
        Min = min;
        Max = max;
    }
}