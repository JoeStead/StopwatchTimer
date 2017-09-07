# Super simple timer for C#
Adds a stopwatch around code. By default, it will write to stdout. If you would like to log it somewhere else, use the overload and pass in an action.
 
 Usage:

```csharp
using (new CodeStopWatch("The thing I'm testing"))
{
    //your code
}

//with an action
using (new CodeStopWatch("The thing I'm testing", s => _logger.Log(s)))
{
    //your code
}
```

That's it!