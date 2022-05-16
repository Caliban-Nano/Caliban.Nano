#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Contracts](Caliban.Nano.Contracts.md 'Caliban.Nano.Contracts')

## IEventAggregator Interface

An interface for a type separated event aggregator.

```csharp
public interface IEventAggregator :
System.IDisposable
```

Derived  
&#8627; [EventAggregator](Caliban.Nano.Events.EventAggregator.md 'Caliban.Nano.Events.EventAggregator')

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
### Methods

<a name='Caliban.Nano.Contracts.IEventAggregator.HasHandler_T_()'></a>

## IEventAggregator.HasHandler<T>() Method

Returns if a handler is subscribed to the type.

```csharp
bool HasHandler<T>();
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IEventAggregator.HasHandler_T_().T'></a>

`T`

The message type.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the type has a handler; otherwise false.

<a name='Caliban.Nano.Contracts.IEventAggregator.Publish_T_(T)'></a>

## IEventAggregator.Publish<T>(T) Method

Publishes a message to all subscribed handlers.

```csharp
void Publish<T>(T message)
    where T : notnull;
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IEventAggregator.Publish_T_(T).T'></a>

`T`

The message type.
#### Parameters

<a name='Caliban.Nano.Contracts.IEventAggregator.Publish_T_(T).message'></a>

`message` [T](Caliban.Nano.Contracts.IEventAggregator.md#Caliban.Nano.Contracts.IEventAggregator.Publish_T_(T).T 'Caliban.Nano.Contracts.IEventAggregator.Publish<T>(T).T')

The message.

<a name='Caliban.Nano.Contracts.IEventAggregator.Subscribe_T_(object)'></a>

## IEventAggregator.Subscribe<T>(object) Method

Subscribes a handler to a type.

```csharp
void Subscribe<T>(object handler);
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IEventAggregator.Subscribe_T_(object).T'></a>

`T`

The message type.
#### Parameters

<a name='Caliban.Nano.Contracts.IEventAggregator.Subscribe_T_(object).handler'></a>

`handler` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The event handler.

<a name='Caliban.Nano.Contracts.IEventAggregator.Unsubscribe_T_(object)'></a>

## IEventAggregator.Unsubscribe<T>(object) Method

Unsubscribes a handler from a type.

```csharp
void Unsubscribe<T>(object handler);
```
#### Type parameters

<a name='Caliban.Nano.Contracts.IEventAggregator.Unsubscribe_T_(object).T'></a>

`T`

The message type.
#### Parameters

<a name='Caliban.Nano.Contracts.IEventAggregator.Unsubscribe_T_(object).handler'></a>

`handler` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The event handler.