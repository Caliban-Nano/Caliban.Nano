#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Contracts](Caliban.Nano.Contracts.md 'Caliban.Nano.Contracts')

## ILogger Interface

An all-purpose logger interface as the lowest common denominator.

```csharp
public interface ILogger :
System.IDisposable
```

Derived  
&#8627; [TraceLogger](Caliban.Nano.TraceLogger.md 'Caliban.Nano.TraceLogger')

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
### Methods

<a name='Caliban.Nano.Contracts.ILogger.Error(string,object[])'></a>

## ILogger.Error(string, object[]) Method

Logs an error message.

```csharp
void Error(string format, params object[] args);
```
#### Parameters

<a name='Caliban.Nano.Contracts.ILogger.Error(string,object[]).format'></a>

`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message format.

<a name='Caliban.Nano.Contracts.ILogger.Error(string,object[]).args'></a>

`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The message arguments.

<a name='Caliban.Nano.Contracts.ILogger.Error(string)'></a>

## ILogger.Error(string) Method

Logs an error message.

```csharp
void Error(string message);
```
#### Parameters

<a name='Caliban.Nano.Contracts.ILogger.Error(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

<a name='Caliban.Nano.Contracts.ILogger.Error(System.Exception,string,object[])'></a>

## ILogger.Error(Exception, string, object[]) Method

Logs an occured exception with a specified message.

```csharp
void Error(System.Exception exception, string format, params object[] args);
```
#### Parameters

<a name='Caliban.Nano.Contracts.ILogger.Error(System.Exception,string,object[]).exception'></a>

`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The occured exception.

<a name='Caliban.Nano.Contracts.ILogger.Error(System.Exception,string,object[]).format'></a>

`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message format.

<a name='Caliban.Nano.Contracts.ILogger.Error(System.Exception,string,object[]).args'></a>

`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The message arguments.

<a name='Caliban.Nano.Contracts.ILogger.Error(System.Exception)'></a>

## ILogger.Error(Exception) Method

Logs an occured exception.

```csharp
void Error(System.Exception exception);
```
#### Parameters

<a name='Caliban.Nano.Contracts.ILogger.Error(System.Exception).exception'></a>

`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The occured exception.

<a name='Caliban.Nano.Contracts.ILogger.Info(string)'></a>

## ILogger.Info(string) Method

Logs an informal message.

```csharp
void Info(string message);
```
#### Parameters

<a name='Caliban.Nano.Contracts.ILogger.Info(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

<a name='Caliban.Nano.Contracts.ILogger.Warn(string)'></a>

## ILogger.Warn(string) Method

Logs a warning message.

```csharp
void Warn(string message);
```
#### Parameters

<a name='Caliban.Nano.Contracts.ILogger.Warn(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.