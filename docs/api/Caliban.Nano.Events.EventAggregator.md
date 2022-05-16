#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Events](Caliban.Nano.Events.md 'Caliban.Nano.Events')

## EventAggregator Class

A thread-safe event aggregator.

```csharp
public class EventAggregator :
Caliban.Nano.Contracts.IEventAggregator,
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EventAggregator

Implements [IEventAggregator](Caliban.Nano.Contracts.IEventAggregator.md 'Caliban.Nano.Contracts.IEventAggregator'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
### Methods

<a name='Caliban.Nano.Events.EventAggregator.Dispose()'></a>

## EventAggregator.Dispose() Method

Clears all subscriptions on dispose.

```csharp
public virtual void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')

<a name='Caliban.Nano.Events.EventAggregator.HasHandler_T_()'></a>

## EventAggregator.HasHandler<T>() Method

Returns if a handler is subscribed to the type.

```csharp
public virtual bool HasHandler<T>();
```
#### Type parameters

<a name='Caliban.Nano.Events.EventAggregator.HasHandler_T_().T'></a>

`T`

The message type.

Implements [HasHandler&lt;T&gt;()](Caliban.Nano.Contracts.IEventAggregator.md#Caliban.Nano.Contracts.IEventAggregator.HasHandler_T_() 'Caliban.Nano.Contracts.IEventAggregator.HasHandler<T>()')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the type has a handler; otherwise false.

<a name='Caliban.Nano.Events.EventAggregator.Publish_T_(T)'></a>

## EventAggregator.Publish<T>(T) Method

Publishes a message to all subscribed handlers.

```csharp
public virtual void Publish<T>(T message)
    where T : notnull;
```
#### Type parameters

<a name='Caliban.Nano.Events.EventAggregator.Publish_T_(T).T'></a>

`T`

The message type.
#### Parameters

<a name='Caliban.Nano.Events.EventAggregator.Publish_T_(T).message'></a>

`message` [T](Caliban.Nano.Events.EventAggregator.md#Caliban.Nano.Events.EventAggregator.Publish_T_(T).T 'Caliban.Nano.Events.EventAggregator.Publish<T>(T).T')

The message.

Implements [Publish&lt;T&gt;(T)](Caliban.Nano.Contracts.IEventAggregator.md#Caliban.Nano.Contracts.IEventAggregator.Publish_T_(T) 'Caliban.Nano.Contracts.IEventAggregator.Publish<T>(T)')

<a name='Caliban.Nano.Events.EventAggregator.Subscribe_T_(object)'></a>

## EventAggregator.Subscribe<T>(object) Method

Subscribes a handler to a type.

```csharp
public virtual void Subscribe<T>(object handler);
```
#### Type parameters

<a name='Caliban.Nano.Events.EventAggregator.Subscribe_T_(object).T'></a>

`T`

The message type.
#### Parameters

<a name='Caliban.Nano.Events.EventAggregator.Subscribe_T_(object).handler'></a>

`handler` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The event handler.

Implements [Subscribe&lt;T&gt;(object)](Caliban.Nano.Contracts.IEventAggregator.md#Caliban.Nano.Contracts.IEventAggregator.Subscribe_T_(object) 'Caliban.Nano.Contracts.IEventAggregator.Subscribe<T>(object)')

<a name='Caliban.Nano.Events.EventAggregator.Unsubscribe_T_(object)'></a>

## EventAggregator.Unsubscribe<T>(object) Method

Unsubscribes a handler from a type.

```csharp
public virtual void Unsubscribe<T>(object handler);
```
#### Type parameters

<a name='Caliban.Nano.Events.EventAggregator.Unsubscribe_T_(object).T'></a>

`T`

The message type.
#### Parameters

<a name='Caliban.Nano.Events.EventAggregator.Unsubscribe_T_(object).handler'></a>

`handler` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The event handler.

Implements [Unsubscribe&lt;T&gt;(object)](Caliban.Nano.Contracts.IEventAggregator.md#Caliban.Nano.Contracts.IEventAggregator.Unsubscribe_T_(object) 'Caliban.Nano.Contracts.IEventAggregator.Unsubscribe<T>(object)')