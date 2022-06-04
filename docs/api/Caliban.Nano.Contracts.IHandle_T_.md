#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Contracts](Caliban.Nano.Contracts.md 'Caliban.Nano.Contracts')

## IHandle<T> Interface

An interface for a general type separated message handler.

```csharp
public interface IHandle<T>
    where T : notnull
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IHandle_T_.T'></a>

`T`

The message type.

Derived  
&#8627; [TraceLogger](Caliban.Nano.TraceLogger.md 'Caliban.Nano.TraceLogger')
### Methods

<a name='Caliban.Nano.Contracts.IHandle_T_.Handle(T)'></a>

## IHandle<T>.Handle(T) Method

Handle the incoming message according to its type.

```csharp
void Handle(T message);
```
#### Parameters

<a name='Caliban.Nano.Contracts.IHandle_T_.Handle(T).message'></a>

`message` [T](Caliban.Nano.Contracts.IHandle_T_.md#Caliban.Nano.Contracts.IHandle_T_.T 'Caliban.Nano.Contracts.IHandle<T>.T')

The message.