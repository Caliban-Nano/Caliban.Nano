#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Events.EventLogger](Caliban.Nano.Events.EventLogger.md 'Caliban.Nano.Events.EventLogger')

## EventLogger Class

An event logger mixin.

```csharp
public static class EventLogger
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EventLogger
### Methods

<a name='Caliban.Nano.Events.EventLogger.EventLogger.Raise(thisCaliban.Nano.Contracts.ILogger,string)'></a>

## EventLogger.Raise(this ILogger, string) Method

Raises a log event for a specified log message.

```csharp
public static void Raise(this Caliban.Nano.Contracts.ILogger _, string message);
```
#### Parameters

<a name='Caliban.Nano.Events.EventLogger.EventLogger.Raise(thisCaliban.Nano.Contracts.ILogger,string)._'></a>

`_` [ILogger](Caliban.Nano.Contracts.ILogger.md 'Caliban.Nano.Contracts.ILogger')

<a name='Caliban.Nano.Events.EventLogger.EventLogger.Raise(thisCaliban.Nano.Contracts.ILogger,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The log message.