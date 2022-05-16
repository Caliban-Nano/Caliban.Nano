#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano](Caliban.Nano.md 'Caliban.Nano')

## TraceLogger Class

A debug trace logger implementing ILogger.

```csharp
public sealed class TraceLogger :
Caliban.Nano.Contracts.ILogger,
Caliban.Nano.Contracts.IHandle<Caliban.Nano.Events.LogEvent>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TraceLogger

Implements [ILogger](Caliban.Nano.Contracts.ILogger.md 'Caliban.Nano.Contracts.ILogger'), [Caliban.Nano.Contracts.IHandle&lt;](Caliban.Nano.Contracts.IHandle_T_.md 'Caliban.Nano.Contracts.IHandle<T>')[LogEvent](Caliban.Nano.Events.LogEvent.md 'Caliban.Nano.Events.LogEvent')[&gt;](Caliban.Nano.Contracts.IHandle_T_.md 'Caliban.Nano.Contracts.IHandle<T>')
### Constructors

<a name='Caliban.Nano.TraceLogger.TraceLogger()'></a>

## TraceLogger() Constructor

Initializes a new instance of this class.

```csharp
public TraceLogger();
```
### Methods

<a name='Caliban.Nano.TraceLogger.Error(string,object[])'></a>

## TraceLogger.Error(string, object[]) Method

Logs an error message.

```csharp
public void Error(string format, params object?[] args);
```
#### Parameters

<a name='Caliban.Nano.TraceLogger.Error(string,object[]).format'></a>

`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message format.

<a name='Caliban.Nano.TraceLogger.Error(string,object[]).args'></a>

`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The message arguments.

Implements [Error(string, object[])](Caliban.Nano.Contracts.ILogger.md#Caliban.Nano.Contracts.ILogger.Error(string,object[]) 'Caliban.Nano.Contracts.ILogger.Error(string, object[])')

<a name='Caliban.Nano.TraceLogger.Error(string)'></a>

## TraceLogger.Error(string) Method

Logs an error message.

```csharp
public void Error(string message);
```
#### Parameters

<a name='Caliban.Nano.TraceLogger.Error(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

Implements [Error(string)](Caliban.Nano.Contracts.ILogger.md#Caliban.Nano.Contracts.ILogger.Error(string) 'Caliban.Nano.Contracts.ILogger.Error(string)')

<a name='Caliban.Nano.TraceLogger.Error(System.Exception,string,object[])'></a>

## TraceLogger.Error(Exception, string, object[]) Method

Logs an occured exception with a specified message.

```csharp
public void Error(System.Exception exception, string format, params object?[] args);
```
#### Parameters

<a name='Caliban.Nano.TraceLogger.Error(System.Exception,string,object[]).exception'></a>

`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The occured exception.

<a name='Caliban.Nano.TraceLogger.Error(System.Exception,string,object[]).format'></a>

`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message format.

<a name='Caliban.Nano.TraceLogger.Error(System.Exception,string,object[]).args'></a>

`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The message arguments.

Implements [Error(Exception, string, object[])](Caliban.Nano.Contracts.ILogger.md#Caliban.Nano.Contracts.ILogger.Error(System.Exception,string,object[]) 'Caliban.Nano.Contracts.ILogger.Error(System.Exception, string, object[])')

<a name='Caliban.Nano.TraceLogger.Error(System.Exception)'></a>

## TraceLogger.Error(Exception) Method

Logs an occured exception.

```csharp
public void Error(System.Exception exception);
```
#### Parameters

<a name='Caliban.Nano.TraceLogger.Error(System.Exception).exception'></a>

`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The occured exception.

Implements [Error(Exception)](Caliban.Nano.Contracts.ILogger.md#Caliban.Nano.Contracts.ILogger.Error(System.Exception) 'Caliban.Nano.Contracts.ILogger.Error(System.Exception)')

<a name='Caliban.Nano.TraceLogger.Info(string)'></a>

## TraceLogger.Info(string) Method

Logs an informal message.

```csharp
public void Info(string message);
```
#### Parameters

<a name='Caliban.Nano.TraceLogger.Info(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

Implements [Info(string)](Caliban.Nano.Contracts.ILogger.md#Caliban.Nano.Contracts.ILogger.Info(string) 'Caliban.Nano.Contracts.ILogger.Info(string)')

<a name='Caliban.Nano.TraceLogger.Warn(string)'></a>

## TraceLogger.Warn(string) Method

Logs a warning message.

```csharp
public void Warn(string message);
```
#### Parameters

<a name='Caliban.Nano.TraceLogger.Warn(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

Implements [Warn(string)](Caliban.Nano.Contracts.ILogger.md#Caliban.Nano.Contracts.ILogger.Warn(string) 'Caliban.Nano.Contracts.ILogger.Warn(string)')