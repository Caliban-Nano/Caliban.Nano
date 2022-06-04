#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.Events](Caliban.Nano.Events.md 'Caliban.Nano.Events')

## EventRaiser<T> Class

A simple wrapper for raising an event externally.

```csharp
public class EventRaiser<T>
    where T : notnull
```
#### Type parameters

<a name='Caliban.Nano.Events.EventRaiser_T_.T'></a>

`T`

The event arguments type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EventRaiser<T>
### Methods

<a name='Caliban.Nano.Events.EventRaiser_T_.Raise(T)'></a>

## EventRaiser<T>.Raise(T) Method

Raises the enclosed event.

```csharp
public virtual void Raise(T e);
```
#### Parameters

<a name='Caliban.Nano.Events.EventRaiser_T_.Raise(T).e'></a>

`e` [T](Caliban.Nano.Events.EventRaiser_T_.md#Caliban.Nano.Events.EventRaiser_T_.T 'Caliban.Nano.Events.EventRaiser<T>.T')

The event arguments.
### Events

<a name='Caliban.Nano.Events.EventRaiser_T_.Event'></a>

## EventRaiser<T>.Event Event

Enclosed event handler.

```csharp
public event EventHandler<T>? Event;
```

#### Event Type
[System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[T](Caliban.Nano.Events.EventRaiser_T_.md#Caliban.Nano.Events.EventRaiser_T_.T 'Caliban.Nano.Events.EventRaiser<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')
### Operators

<a name='Caliban.Nano.Events.EventRaiser_T_.op_Addition(Caliban.Nano.Events.EventRaiser_T_,System.EventHandler_T_)'></a>

## EventRaiser<T>.operator +(EventRaiser<T>, EventHandler<T>) Operator

Attaches an event handler to the enclosed event.

```csharp
public static Caliban.Nano.Events.EventRaiser<T> operator +(Caliban.Nano.Events.EventRaiser<T> @this, System.EventHandler<T> handler);
```
#### Parameters

<a name='Caliban.Nano.Events.EventRaiser_T_.op_Addition(Caliban.Nano.Events.EventRaiser_T_,System.EventHandler_T_).this'></a>

`this` [Caliban.Nano.Events.EventRaiser&lt;](Caliban.Nano.Events.EventRaiser_T_.md 'Caliban.Nano.Events.EventRaiser<T>')[T](Caliban.Nano.Events.EventRaiser_T_.md#Caliban.Nano.Events.EventRaiser_T_.T 'Caliban.Nano.Events.EventRaiser<T>.T')[&gt;](Caliban.Nano.Events.EventRaiser_T_.md 'Caliban.Nano.Events.EventRaiser<T>')

The event raiser.

<a name='Caliban.Nano.Events.EventRaiser_T_.op_Addition(Caliban.Nano.Events.EventRaiser_T_,System.EventHandler_T_).handler'></a>

`handler` [System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[T](Caliban.Nano.Events.EventRaiser_T_.md#Caliban.Nano.Events.EventRaiser_T_.T 'Caliban.Nano.Events.EventRaiser<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')

The event handler.

#### Returns
[Caliban.Nano.Events.EventRaiser&lt;](Caliban.Nano.Events.EventRaiser_T_.md 'Caliban.Nano.Events.EventRaiser<T>')[T](Caliban.Nano.Events.EventRaiser_T_.md#Caliban.Nano.Events.EventRaiser_T_.T 'Caliban.Nano.Events.EventRaiser<T>.T')[&gt;](Caliban.Nano.Events.EventRaiser_T_.md 'Caliban.Nano.Events.EventRaiser<T>')  
Returns the given event raiser.

<a name='Caliban.Nano.Events.EventRaiser_T_.op_Subtraction(Caliban.Nano.Events.EventRaiser_T_,System.EventHandler_T_)'></a>

## EventRaiser<T>.operator -(EventRaiser<T>, EventHandler<T>) Operator

Detaches an event handler to the enclosed event.

```csharp
public static Caliban.Nano.Events.EventRaiser<T> operator -(Caliban.Nano.Events.EventRaiser<T> @this, System.EventHandler<T> handler);
```
#### Parameters

<a name='Caliban.Nano.Events.EventRaiser_T_.op_Subtraction(Caliban.Nano.Events.EventRaiser_T_,System.EventHandler_T_).this'></a>

`this` [Caliban.Nano.Events.EventRaiser&lt;](Caliban.Nano.Events.EventRaiser_T_.md 'Caliban.Nano.Events.EventRaiser<T>')[T](Caliban.Nano.Events.EventRaiser_T_.md#Caliban.Nano.Events.EventRaiser_T_.T 'Caliban.Nano.Events.EventRaiser<T>.T')[&gt;](Caliban.Nano.Events.EventRaiser_T_.md 'Caliban.Nano.Events.EventRaiser<T>')

The event raiser.

<a name='Caliban.Nano.Events.EventRaiser_T_.op_Subtraction(Caliban.Nano.Events.EventRaiser_T_,System.EventHandler_T_).handler'></a>

`handler` [System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[T](Caliban.Nano.Events.EventRaiser_T_.md#Caliban.Nano.Events.EventRaiser_T_.T 'Caliban.Nano.Events.EventRaiser<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')

The event handler.

#### Returns
[Caliban.Nano.Events.EventRaiser&lt;](Caliban.Nano.Events.EventRaiser_T_.md 'Caliban.Nano.Events.EventRaiser<T>')[T](Caliban.Nano.Events.EventRaiser_T_.md#Caliban.Nano.Events.EventRaiser_T_.T 'Caliban.Nano.Events.EventRaiser<T>.T')[&gt;](Caliban.Nano.Events.EventRaiser_T_.md 'Caliban.Nano.Events.EventRaiser<T>')  
Returns the given event raiser.