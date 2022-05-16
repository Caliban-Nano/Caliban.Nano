#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Events](Caliban.Nano.Events.md 'Caliban.Nano.Events')

## LogEvent Class

A simple log event class.

```csharp
public class LogEvent
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; LogEvent
### Constructors

<a name='Caliban.Nano.Events.LogEvent.LogEvent(string)'></a>

## LogEvent(string) Constructor

Initializes a new instance of this class with a specified log message.

```csharp
public LogEvent(string message);
```
#### Parameters

<a name='Caliban.Nano.Events.LogEvent.LogEvent(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The log message.
### Fields

<a name='Caliban.Nano.Events.LogEvent.Message'></a>

## LogEvent.Message Field

The log message.

```csharp
public readonly string Message;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='Caliban.Nano.Events.LogEvent.ToString()'></a>

## LogEvent.ToString() Method

Returns the log message.

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The log message.